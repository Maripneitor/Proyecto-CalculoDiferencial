using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.Expression;

namespace Proyecto_CalculoDiferencial.forms
{
    public partial class frmtrapecio : Form
    {
        public frmtrapecio()
        {
            InitializeComponent();
        }

        private void frmtrapecio_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBoxPasos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            listBoxPasos.Items.Clear();
            try
            {
                double a = double.Parse(txtlimiteinferior.Text);
                double b = double.Parse(txtlimitesuperior.Text);
                int n = int.Parse(txtintervalo.Text);

                if (n <= 0)
                {
                    MessageBox.Show("El número de intervalos debe ser mayor a cero.");
                    return;
                }

                string funcionTexto = txtfuncion.Text;
                Func<double, double> funcion = x => EvaluarFuncion(funcionTexto, x);

                double resultado = metodotrapecio(funcion, a, b, n);
                lbresultado.Text = "Resultado: " + resultado.ToString();

                
                GraficarFuncion(funcion, a, b, n);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private double metodotrapecio(Func<double, double> funcion, double a, double b, int n)
        {
            double h = (b - a) / n;
            double suma = 0.5 * (funcion(a) + funcion(b));

            listBoxPasos.Items.Add($"h = {h}");
            listBoxPasos.Items.Add("");
            listBoxPasos.Items.Add($"f(a) = {funcion(a)}, f(b) = {funcion(b)}");
            listBoxPasos.Items.Add("");
            listBoxPasos.Items.Add($"Suma inicial = {suma}");
            listBoxPasos.Items.Add("");

            for (int i = 1; i < n; i++)
            {
                double x_i = a + i * h;
                double f_x_i = funcion(x_i);
                suma += f_x_i;
                listBoxPasos.Items.Add($"i = {i}, x_i = {x_i}, f(x_i) = {f_x_i}, Suma = {suma}");
                listBoxPasos.Items.Add("");
            }

            double resultado = h * suma;
            listBoxPasos.Items.Add("");
            listBoxPasos.Items.Add($"Resultado final = {resultado}");
            return resultado;
        }

        private double EvaluarFuncion(string expresion, double x)
        {
            try
            {
                string expresionReemplazada = expresion.Replace("x", x.ToString());
                var expression = Infix.ParseOrThrow(expresionReemplazada);
                var variables = new Dictionary<string, FloatingPoint>
                {
                    { "PI", Math.PI }
                };

                var result = Evaluate.Evaluate(variables, expression);
                if (result is FloatingPoint floatingPoint)
                {
                    return (double)floatingPoint.RealValue;
                }
                else
                {
                    throw new InvalidOperationException("La evaluación de la función no devolvió un número de punto flotante.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al evaluar la función: " + ex.Message);
            }
        }

        private void GraficarFuncion(Func<double, double> funcion, double a, double b, int n)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);

            Pen axisPen = new Pen(Color.Black, 2);
            Pen functionPen = new Pen(Color.Blue, 2);
            Pen pointPen = new Pen(Color.Red, 5);
            Pen penGuia = new Pen(Color.LightGray, 1);

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            float escalaX = 20f; 
            float escalaY = 20f; 
            float origenX = width / 2;
            float origenY = height / 2;

            
            for (int i = -10; i <= 10; i++)
            {
                
                float posX = origenX + i * escalaX;
                g.DrawLine(penGuia, posX, 0, posX, height);

                
                float posY = origenY - i * escalaY;
                g.DrawLine(penGuia, 0, posY, width, posY);
            }

            
            g.DrawLine(axisPen, 0, height / 2, width, height / 2); 
            g.DrawLine(axisPen, width / 2, 0, width / 2, height); 

            
            for (int i = 0; i <= width; i += 40)
            {
                g.DrawLine(Pens.Gray, i, height / 2 - 5, i, height / 2 + 5);
                g.DrawString(((i - width / 2) / 40).ToString(), new Font("Arial", 8), Brushes.Black, i, height / 2 + 5);
            }

            for (int j = 0; j <= height; j += 40)
            {
                g.DrawLine(Pens.Gray, width / 2 - 5, j, width / 2 + 5, j);
                g.DrawString(((height / 2 - j) / 40).ToString(), new Font("Arial", 8), Brushes.Black, width / 2 + 5, j);
            }

            double h = (b - a) / n;

            
            List<PointF> puntos = new List<PointF>();
            for (double x = a; x <= b; x += 0.01)
            {
                double y = funcion(x);
                int pixelX = (int)((x - a) / (b - a) * width);
                int pixelY = height / 2 - (int)(y * height / (2 * Math.Max(Math.Abs(funcion(a)), Math.Abs(funcion(b)))));

                if (pixelX >= 0 && pixelX < width && pixelY >= 0 && pixelY < height)
                {
                    puntos.Add(new PointF(pixelX, pixelY));
                }
            }

            if (puntos.Count > 1)
            {
                g.DrawLines(functionPen, puntos.ToArray());
            }

           
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            for (int i = 0; i <= n; i++)
            {
                double x_i = a + i * h;
                double y_i = funcion(x_i);
                int pixelX = (int)((x_i - a) / (b - a) * width);
                int pixelY = height / 2 - (int)(y_i * height / (2 * Math.Max(Math.Abs(funcion(a)), Math.Abs(funcion(b)))));

                if (pixelX >= 0 && pixelX < width && pixelY >= 0 && pixelY < height)
                {
                    g.DrawEllipse(pointPen, pixelX - 2, pixelY - 2, 5, 5);
                    g.DrawString($"({x_i:0.00}, {y_i:0.00})", drawFont, drawBrush, pixelX + 5, pixelY - 15);
                }
            }

            pictureBox1.Image = bitmap;
        }
    }
}
