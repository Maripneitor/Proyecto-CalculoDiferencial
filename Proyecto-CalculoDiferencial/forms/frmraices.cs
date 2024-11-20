using System;
using System.Text;
using System.Windows.Forms;
using NCalc;

namespace Proyecto_CalculoDiferencial.forms
{
    public partial class frmraices : Form
    {
        public frmraices()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncion.Text;
            double limiteInferior = double.Parse(txtLimiteInferior.Text);
            double limiteSuperior = double.Parse(txtLimiteSuperior.Text);

            rtbPasos.Clear();

            double raiz = MetodoBiseccion(funcion, limiteInferior, limiteSuperior);
            txtResultado.Text = $"Raíz encontrada: {raiz}";

            MostrarPasos(funcion, limiteInferior, limiteSuperior);
        }

        private double MetodoBiseccion(string funcion, double a, double b)
        {
            double c = 0;
            while ((b - a) >= 0.001)
            {
                c = (a + b) / 2;

                double fA = EvaluarFuncion(funcion, a);
                double fC = EvaluarFuncion(funcion, c);

                if (double.IsNaN(fC))
                {
                    MessageBox.Show("El resultado de la función es demasiado grande o pequeño para ser manejado.");
                    return c; // Retorna el último valor calculado
                }

                if (fC == 0.0)
                    break;

                if (fC * fA < 0)
                    b = c; // La raíz está entre a y c
                else
                    a = c; // La raíz está entre c y b
            }
            return c;
        }

        private double EvaluarFuncion(string funcion, double x)
        {
            try
            {
                Expression e = new Expression(funcion);
                e.Parameters["x"] = x;

                var result = e.Evaluate();

                if (result is double)
                {
                    return (double)result;
                }
                else if (result is int)
                {
                    return Convert.ToDouble(result);
                }
                else
                {
                    throw new InvalidOperationException("La evaluación debe devolver un número.");
                }
            }
            catch (OverflowException)
            {
                return double.NaN; // Devuelve NaN si hay un desbordamiento
            }
            catch (EvaluationException ex)
            {
                MessageBox.Show($"Error en la evaluación: {ex.Message}");
                return double.NaN; // Devuelve NaN si hay un error de evaluación
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
                return double.NaN; // Devuelve NaN para cualquier otro error
            }
        }

        private void MostrarPasos(string funcion, double a, double b)
        {
            StringBuilder pasos = new StringBuilder();
            pasos.AppendLine($"Función: {funcion}");
            pasos.AppendLine($"Intervalo inicial: [{a}, {b}]");

            while ((b - a) >= 0.001)
            {
                double c = (a + b) / 2;

                pasos.AppendLine($"Cálculo del punto medio: c = ({a} + {b}) / 2 = {c}");

                double fC = EvaluarFuncion(funcion, c);

                if (double.IsNaN(fC))
                {
                    pasos.AppendLine("El resultado de la función es demasiado grande o pequeño para ser manejado.");
                    break; // Salir del bucle si hay un error en f(c)
                }

                if (fC == 0.0)
                {
                    pasos.AppendLine($"Raíz exacta encontrada: {c}");
                    break;
                }

                double fA = EvaluarFuncion(funcion, a);

                if (fC * fA < 0)
                {
                    b = c; // La raíz está entre a y c
                    pasos.AppendLine($"La raíz está entre [{a}, {c}]");
                }
                else
                {
                    a = c; // La raíz está entre c y b
                    pasos.AppendLine($"La raíz está entre [{c}, {b}]");
                }

                pasos.AppendLine($"Nuevo intervalo: [{a}, {b}]");

                rtbPasos.Text = pasos.ToString();

                rtbPasos.SelectionStart = rtbPasos.Text.Length; // Mover el cursor al final
                rtbPasos.ScrollToCaret(); // Desplazar hacia abajo para mostrar el final
            }

            rtbPasos.Text = pasos.ToString(); // Asegurarse de que se muestre todo al final
        }
    }
}