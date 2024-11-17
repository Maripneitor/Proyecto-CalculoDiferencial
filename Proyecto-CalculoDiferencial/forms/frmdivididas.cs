using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics; // Asegúrate de agregar esta referencia
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace Proyecto_CalculoDiferencial.forms
{
    public partial class frmdivididas : Form
    {
        public frmdivididas()
        {
            InitializeComponent();
        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string inputFuncion = txtFuncion.Text;

            if (string.IsNullOrWhiteSpace(inputFuncion))
            {
                MessageBox.Show("Por favor, introduce una función válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsFuncionValida(inputFuncion))
            {
                MessageBox.Show("La función ingresada no es válida. Revisa la sintaxis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar resultados anteriores
            txtResultados.Clear();

            try
            {
                // Procesar y traducir la función
                string funcionTraducida = TraducirFunciones(inputFuncion);
                var funcion = Expr.Parse(funcionTraducida);

                // Derivar la función
                var derivada = funcion.Differentiate("x");
                var segundaDerivada = derivada.Differentiate("x");

                // Mostrar las derivadas
                txtResultados.AppendText($"Función original: {funcion}\n");
                txtResultados.AppendText($"Primera derivada: {derivada}\n");
                txtResultados.AppendText($"Segunda derivada: {segundaDerivada}\n\n");

                // Detectar máximos y mínimos
                DetectarExtremos(funcion, derivada, segundaDerivada);

                // Graficar la función
                GraficarFuncion(funcion, derivada, segundaDerivada);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DetectarExtremos(Expr funcion, Expr derivada, Expr segundaDerivada)
        {
            txtResultados.AppendText("Máximos y mínimos:\n");

            double[] xValues = Enumerable.Range(-10, 21).Select(i => (double)i).ToArray();
            foreach (var x in xValues)
            {
                double valorDerivada = EvaluarFuncion(derivada, x);

                if (Math.Abs(valorDerivada) < 1e-5)
                {
                    double valorSegundaDerivada = EvaluarFuncion(segundaDerivada, x);
                    double valorFuncion = EvaluarFuncion(funcion, x);

                    if (valorSegundaDerivada > 0)
                        txtResultados.AppendText($"Mínimo en x = {x:F2}, g(x) = {valorFuncion:F4}\n");
                    else if (valorSegundaDerivada < 0)
                        txtResultados.AppendText($"Máximo en x = {x:F2}, g(x) = {valorFuncion:F4}\n");
                    else
                        txtResultados.AppendText($"Punto de inflexión en x = {x:F2}, g(x) = {valorFuncion:F4}\n");
                }
            }

            txtResultados.AppendText("\n");
        }

        private void GraficarFuncion(Expr funcion, Expr derivada, Expr segundaDerivada)
        {
            Bitmap bitmap = new Bitmap(pictureBoxFuncion.Width, pictureBoxFuncion.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            int width = pictureBoxFuncion.Width;
            int height = pictureBoxFuncion.Height;

            float escalaX = 20f; // Escala en el eje X (pixeles por unidad)
            float escalaY = 20f; // Escala en el eje Y (pixeles por unidad)
            float origenX = width / 2;
            float origenY = height / 2;

            // Dibujar cuadrícula
            Pen penGuia = new Pen(Color.LightGray, 1);
            for (int i = -10; i <= 10; i++)
            {
                // Líneas verticales
                float posX = origenX + i * escalaX;
                g.DrawLine(penGuia, posX, 0, posX, height);

                // Líneas horizontales
                float posY = origenY - i * escalaY;
                g.DrawLine(penGuia, 0, posY, width, posY);
            }

            // Dibujar ejes
            Pen penEjes = new Pen(Color.Black, 2);
            g.DrawLine(penEjes, 0, origenY, width, origenY); // Eje X
            g.DrawLine(penEjes, origenX, 0, origenX, height); // Eje Y

            // Dibujar etiquetas en los ejes
            Font font = new Font("Arial", 9);
            Brush brush = Brushes.Black;

            for (int i = -10; i <= 10; i++)
            {
                if (i != 0) // Evitar el 0 en las etiquetas de los ejes
                {
                    // Etiquetas del eje X
                    float posX = origenX + i * escalaX;
                    g.DrawString(i.ToString(), font, brush, posX - 10, origenY + 5);

                    // Etiquetas del eje Y
                    float posY = origenY - i * escalaY;
                    g.DrawString(i.ToString(), font, brush, origenX + 5, posY - 10);
                }
            }

            // Graficar la función
            Pen penFuncion = new Pen(Color.Blue, 2);
            List<PointF> puntosFuncion = new List<PointF>();
            double[] xValues = Enumerable.Range(-200, 401).Select(i => i * 0.05).ToArray(); // Valores de x entre -10 y 10 con pasos de 0.05

            foreach (var x in xValues)
            {
                try
                {
                    double y = EvaluarFuncion(funcion, x);
                    float px = origenX + (float)(x * escalaX);
                    float py = origenY - (float)(y * escalaY);

                    // Solo agregar puntos visibles dentro del PictureBox
                    if (px >= 0 && px < width && py >= 0 && py < height)
                    {
                        puntosFuncion.Add(new PointF(px, py));
                    }
                }
                catch
                {
                    // Ignorar puntos fuera del dominio o valores no válidos
                }
            }

            if (puntosFuncion.Count > 1)
            {
                g.DrawLines(penFuncion, puntosFuncion.ToArray());
            }

            // Graficar máximos y mínimos
            Pen penExtremos = new Pen(Color.Red, 3);
            foreach (var x in xValues)
            {
                try
                {
                    double valorDerivada = EvaluarFuncion(derivada, x);
                    if (Math.Abs(valorDerivada) < 1e-5) // Punto crítico
                    {
                        double valorSegundaDerivada = EvaluarFuncion(segundaDerivada, x);
                        if (valorSegundaDerivada != 0)
                        {
                            double y = EvaluarFuncion(funcion, x);
                            float px = origenX + (float)(x * escalaX);
                            float py = origenY - (float)(y * escalaY);

                            // Dibujar un círculo para identificar máximo/mínimo
                            g.FillEllipse(Brushes.Red, px - 4, py - 4, 8, 8);
                        }
                    }
                }
                catch
                {
                    // Ignorar valores no válidos
                }
            }

            // Asignar el gráfico al PictureBox
            pictureBoxFuncion.Image = bitmap;
        }



        private double EvaluarFuncion(Expr funcion, double x)
        {
            try
            {
                var variables = new Dictionary<string, FloatingPoint>
                {
                    { "x", (FloatingPoint)x }
                };

                var resultado = funcion.Evaluate(variables);

                if (resultado.IsReal)
                {
                    return resultado.RealValue;
                }

                throw new Exception("El resultado no se puede convertir a un valor real.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al evaluar la función en x = {x}: {ex.Message}");
            }
        }

        private string TraducirFunciones(string funcion)
        {
            funcion = funcion.Replace("sen", "sin")
                             .Replace("cos", "cos")
                             .Replace("tan", "tan")
                             .Replace("ln", "log")
                             .Replace("√", "sqrt");

            funcion = System.Text.RegularExpressions.Regex.Replace(funcion, @"(\))(\()", "$1*$2");
            funcion = System.Text.RegularExpressions.Regex.Replace(funcion, @"([0-9a-zA-Z])(\()", "$1*$2");
            funcion = System.Text.RegularExpressions.Regex.Replace(funcion, @"(\))([0-9a-zA-Z])", "$1*$2");

            return funcion;
        }

        private bool EsFuncionValida(string funcion)
        {
            try
            {
                string funcionTraducida = TraducirFunciones(funcion);
                var parsed = Expr.Parse(funcionTraducida);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
