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
            listBoxPasos.Items.Add($"f(a) = {funcion(a)}, f(b) = {funcion(b)}");
            listBoxPasos.Items.Add($"Suma inicial = {suma}");

            for (int i = 1; i < n; i++)
            {
                double x_i = a + i * h;
                double f_x_i = funcion(x_i);
                suma += f_x_i;
                listBoxPasos.Items.Add($"i = {i}, x_i = {x_i}, f(x_i) = {f_x_i}, Suma = {suma}");
            }

            double resultado = h * suma;
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
    }
}
