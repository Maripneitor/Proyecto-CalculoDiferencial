using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace Proyecto_CalculoDiferencial.forms
{
    public partial class frmnumericas : Form
    {
        public frmnumericas()
        {
            InitializeComponent();
            VerProcedimiento.Enabled = false;
        }

        private double EvaluarFuncion(string funcion, double x)
        {
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MessageBox.Show("La función no puede estar vacía.");
                return double.NaN;
            }

            try
            {
                var expr = Expr.Parse(funcion);
                var xSymbol = Expr.Variable("x");
                var context = new Dictionary<string, FloatingPoint> { { "x", x } };

                var valor = expr.Evaluate(context);
                return Math.Round(valor.RealValue, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al evaluar la función. Detalles: {ex.Message}");
                return double.NaN;
            }
        }

        private double CalcularDerivadaCentrada(string funcion, double x, double h)
        {
            if (h <= 0)
            {
                MessageBox.Show("El valor de h debe ser positivo.");
                return double.NaN;
            }

            double f_x_plus_h = Math.Round(EvaluarFuncion(funcion, x + h), 4);
            double f_x_minus_h = Math.Round(EvaluarFuncion(funcion, x - h), 4);

            if (double.IsNaN(f_x_plus_h) || double.IsNaN(f_x_minus_h))
            {
                return double.NaN;
            }

            return Math.Round((f_x_plus_h - f_x_minus_h) / (2 * h), 4);
        }

        private void CalcularDV_Click(object sender, EventArgs e)
        {
            string funcion = FuncionDN.Text; //Ingresar la función
            if (!double.TryParse(ValorX.Text, out double x))
            {
                MessageBox.Show("Ingrese un valor numérico válido para x.");
                return;
            }

            // Tamaño del paso h
            double h = 0.01; 

            double resultado = CalcularDerivadaCentrada(funcion, x, h);

            if (double.IsNaN(resultado))
            {
                MessageBox.Show("Error al calcular la derivada.");
            }
            else
            {
                ResultadoFinal.Text = $"{resultado}"; // Mostrar el resultado
                VerProcedimiento.Enabled = true;
            }
        }

        private void VerProcedimiento_Click(object sender, EventArgs e)
        {
            string funcion = FuncionDN.Text; //Ingresar funcion
            if (!double.TryParse(ValorX.Text, out double x))
            {
                MessageBox.Show("Ingrese un valor numérico válido para x.");
                return;
            }

            double h = 0.01; // Paso fijo

            // Evaluar f(x + h) y f(x - h)
            double f_x_plus_h = Math.Round(EvaluarFuncion(funcion, x + h), 4);
            double f_x_minus_h = Math.Round(EvaluarFuncion(funcion, x - h), 4);

            if (double.IsNaN(f_x_plus_h) || double.IsNaN(f_x_minus_h))
            {
                MessageBox.Show("Error al calcular la función en los puntos necesarios para el procedimiento.");
                return;
            }

            string procedimiento = $"Paso 1: Evaluar f(x + h):\n" +
                                  $"f({x} + {h}) = {f_x_plus_h}\n\n" +
                                  $"Paso 2: Evaluar f(x - h):\n" +
                                  $"f({x} - {h}) = {f_x_minus_h}\n\n" +
                                  $"Paso 3: Calcular la derivada centrada:\n" +
                                  $"f'({x}) ≈ (f({x} + {h}) - f({x} - {h})) / (2 * {h})\n" +
                                  $"f'({x}) ≈ ({f_x_plus_h} - {f_x_minus_h}) / (2 * {h})\n\n" +
                                  $"Resultado: f'({x}) ≈ {Math.Round((f_x_plus_h - f_x_minus_h) / (2 * h), 4)}";
            ProcedimientoDN.Text = procedimiento;
            VerProcedimiento.Enabled = false;
        }

        private void BorrarDT_Click(object sender, EventArgs e)
        {
            FuncionDN.Text = string.Empty;
            ValorX.Text = string.Empty;
            ResultadoFinal.Text = "0";
            ResultadoFinal.Font = new Font("Segoe UI", 12);
            ProcedimientoDN.Text = "Procedimiento...";
            ProcedimientoDN.Font = new Font("Segoe UI", 12);
        }

    }
}
