using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace Proyecto_CalculoDiferencial.forms
{
    public partial class frmsimpson : Form
    {
        public frmsimpson()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string funcion = txtFuncion.Text;
                double a = double.Parse(txtLimiteInferior.Text);
                double b = double.Parse(txtLimiteSuperior.Text);
                int n = int.Parse(txtSubintervalos.Text);

                if (n % 2 != 0)
                {
                    MessageBox.Show("El número de subintervalos debe ser par.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double resultado = CalcularIntegralSimpson(funcion, a, b, n);
                txtResultado.Text = resultado.ToString("F4");

                MostrarProcedimiento(funcion, a, b, n);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularIntegralSimpson(string funcion, double a, double b, int n)
        {
            double h = (b - a) / n;
            double suma = 0;

            suma += EvaluarFuncion(funcion, a);
            suma += EvaluarFuncion(funcion, b);

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                double coef = (i % 2 == 0) ? 2 : 4;
                suma += coef * EvaluarFuncion(funcion, x);
            }

            return (h / 3) * suma;
        }

        private double EvaluarFuncion(string funcion, double x)
        {
            Expression e = new Expression(funcion);
            e.Parameters["x"] = x;
            return Convert.ToDouble(e.Evaluate());
        }

        private void MostrarProcedimiento(string funcion, double a, double b, int n)
        {
            rtbProcedimiento.Clear();

            double h = (b - a) / n;
            rtbProcedimiento.AppendText($"Método de Simpson:\n\n");

            rtbProcedimiento.AppendText($"f(x) = {funcion}\n");
            rtbProcedimiento.AppendText($"Intervalo: [{a}, {b}]\n");
            rtbProcedimiento.AppendText($"Número de subintervalos: {n}\n\n");

            rtbProcedimiento.AppendText($"Evaluamos en los puntos: {a} y {b}\n");
            rtbProcedimiento.AppendText($"f({a}) = {EvaluarFuncion(funcion, a)}\n");
            rtbProcedimiento.AppendText($"f({b}) = {EvaluarFuncion(funcion, b)}\n\n");

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                double coef = (i % 2 == 0) ? 2 : 4;
                rtbProcedimiento.AppendText($"f({x}) = {EvaluarFuncion(funcion, x)} (coef. {coef})\n");
            }

            rtbProcedimiento.AppendText("\nCálculo final:\n");
            rtbProcedimiento.AppendText($"Integral ≈ {h} / 3 * (f({a}) + 4 * sum_odd + 2 * sum_even + f({b}))\n");
        }
    }
}