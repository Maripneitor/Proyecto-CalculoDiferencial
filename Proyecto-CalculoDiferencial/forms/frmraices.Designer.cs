namespace Proyecto_CalculoDiferencial.forms
{
    partial class frmraices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFuncion = new TextBox();
            txtLimiteInferior = new TextBox();
            txtLimiteSuperior = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            rtbPasos = new RichTextBox();
            txtResultado = new TextBox();
            label5 = new Label();
            lblFuncion = new Label();
            lblLimiteInferior = new Label();
            lblLimiteSuperior = new Label();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(97, 54);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(150, 27);
            txtFuncion.TabIndex = 0;
            // 
            // txtLimiteInferior
            // 
            txtLimiteInferior.Location = new Point(12, 119);
            txtLimiteInferior.Name = "txtLimiteInferior";
            txtLimiteInferior.Size = new Size(137, 27);
            txtLimiteInferior.TabIndex = 1;
            // 
            // txtLimiteSuperior
            // 
            txtLimiteSuperior.Location = new Point(167, 119);
            txtLimiteSuperior.Name = "txtLimiteSuperior";
            txtLimiteSuperior.Size = new Size(144, 27);
            txtLimiteSuperior.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(519, 12);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(160, 39);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular Raices";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(540, 61);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(121, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Raiz encontrada";
            // 
            // rtbPasos
            // 
            rtbPasos.Location = new Point(416, 132);
            rtbPasos.Name = "rtbPasos";
            rtbPasos.Size = new Size(403, 319);
            rtbPasos.TabIndex = 5;
            rtbPasos.Text = "";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(519, 93);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(160, 27);
            txtResultado.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(386, 20);
            label5.TabIndex = 17;
            label5.Text = "Favor de escribir la función sin el f(x), g(x) entre otros";
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncion.Location = new Point(78, 31);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(189, 20);
            lblFuncion.TabIndex = 18;
            lblFuncion.Text = "Función en términos de x:";
            // 
            // lblLimiteInferior
            // 
            lblLimiteInferior.AutoSize = true;
            lblLimiteInferior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimiteInferior.Location = new Point(12, 96);
            lblLimiteInferior.Name = "lblLimiteInferior";
            lblLimiteInferior.Size = new Size(137, 20);
            lblLimiteInferior.TabIndex = 19;
            lblLimiteInferior.Text = "Límite inferior (a):";
            // 
            // lblLimiteSuperior
            // 
            lblLimiteSuperior.AutoSize = true;
            lblLimiteSuperior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimiteSuperior.Location = new Point(167, 96);
            lblLimiteSuperior.Name = "lblLimiteSuperior";
            lblLimiteSuperior.Size = new Size(144, 20);
            lblLimiteSuperior.TabIndex = 20;
            lblLimiteSuperior.Text = "Límite superior (b):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(343, 23);
            label1.TabIndex = 21;
            label1.Text = "Representación correcta para operaciones";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 192);
            label8.Name = "label8";
            label8.Size = new Size(294, 20);
            label8.TabIndex = 22;
            label8.Text = "Las ¨x¨ siempre deben de ir en minúscula.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(343, 20);
            label2.TabIndex = 23;
            label2.Text = "Sin, Cos, Tan y Log (Todas inician con Mayúscula)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(333, 20);
            label6.TabIndex = 24;
            label6.Text = "además si estos llevan una x va entre paréntesis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 252);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 25;
            label7.Text = "ejemplo: Sin (x).";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 272);
            label3.Name = "label3";
            label3.Size = new Size(242, 20);
            label3.TabIndex = 26;
            label3.Text = "Raíz = Sqrt (Inicia con mayúscula).";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 292);
            label4.Name = "label4";
            label4.Size = new Size(367, 20);
            label4.TabIndex = 27;
            label4.Text = "El exponen se representa con ^n y si es x a la 1 es *x.";
            // 
            // frmraices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 487);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(lblLimiteSuperior);
            Controls.Add(lblLimiteInferior);
            Controls.Add(lblFuncion);
            Controls.Add(label5);
            Controls.Add(txtResultado);
            Controls.Add(rtbPasos);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtLimiteSuperior);
            Controls.Add(txtLimiteInferior);
            Controls.Add(txtFuncion);
            Name = "frmraices";
            Text = "frmraices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFuncion;
        private TextBox txtLimiteInferior;
        private TextBox txtLimiteSuperior;
        private Button btnCalcular;
        private Label lblResultado;
        private RichTextBox rtbPasos;
        private TextBox txtResultado;
        private Label label5;
        private Label lblFuncion;
        private Label lblLimiteInferior;
        private Label lblLimiteSuperior;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label4;
    }
}