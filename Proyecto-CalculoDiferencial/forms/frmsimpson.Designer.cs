namespace Proyecto_CalculoDiferencial.forms
{
    partial class frmsimpson
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
            lblFuncion = new Label();
            txtFuncion = new TextBox();
            lblLimiteInferior = new Label();
            txtLimiteInferior = new TextBox();
            lblLimiteSuperior = new Label();
            txtLimiteSuperior = new TextBox();
            lblSubintervalos = new Label();
            txtSubintervalos = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            rtbProcedimiento = new RichTextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncion.Location = new Point(85, 40);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(189, 20);
            lblFuncion.TabIndex = 0;
            lblFuncion.Text = "Función en términos de x:";
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(85, 74);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(189, 27);
            txtFuncion.TabIndex = 1;
            // 
            // lblLimiteInferior
            // 
            lblLimiteInferior.AutoSize = true;
            lblLimiteInferior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimiteInferior.Location = new Point(32, 117);
            lblLimiteInferior.Name = "lblLimiteInferior";
            lblLimiteInferior.Size = new Size(137, 20);
            lblLimiteInferior.TabIndex = 2;
            lblLimiteInferior.Text = "Límite inferior (a):";
            // 
            // txtLimiteInferior
            // 
            txtLimiteInferior.Location = new Point(32, 150);
            txtLimiteInferior.Name = "txtLimiteInferior";
            txtLimiteInferior.Size = new Size(137, 27);
            txtLimiteInferior.TabIndex = 3;
            // 
            // lblLimiteSuperior
            // 
            lblLimiteSuperior.AutoSize = true;
            lblLimiteSuperior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimiteSuperior.Location = new Point(187, 117);
            lblLimiteSuperior.Name = "lblLimiteSuperior";
            lblLimiteSuperior.Size = new Size(144, 20);
            lblLimiteSuperior.TabIndex = 4;
            lblLimiteSuperior.Text = "Límite superior (b):";
            // 
            // txtLimiteSuperior
            // 
            txtLimiteSuperior.Location = new Point(187, 150);
            txtLimiteSuperior.Name = "txtLimiteSuperior";
            txtLimiteSuperior.Size = new Size(144, 27);
            txtLimiteSuperior.TabIndex = 5;
            // 
            // lblSubintervalos
            // 
            lblSubintervalos.AutoSize = true;
            lblSubintervalos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubintervalos.Location = new Point(59, 196);
            lblSubintervalos.Name = "lblSubintervalos";
            lblSubintervalos.Size = new Size(230, 20);
            lblSubintervalos.TabIndex = 6;
            lblSubintervalos.Text = "Número de subintervalos (par):";
            // 
            // txtSubintervalos
            // 
            txtSubintervalos.Location = new Point(114, 229);
            txtSubintervalos.Name = "txtSubintervalos";
            txtSubintervalos.Size = new Size(110, 27);
            txtSubintervalos.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(489, 32);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(160, 37);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular Integral";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(526, 81);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(79, 20);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            // 
            // rtbProcedimiento
            // 
            rtbProcedimiento.Location = new Point(378, 168);
            rtbProcedimiento.Name = "rtbProcedimiento";
            rtbProcedimiento.ReadOnly = true;
            rtbProcedimiento.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbProcedimiento.Size = new Size(355, 270);
            rtbProcedimiento.TabIndex = 10;
            rtbProcedimiento.Text = "";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(526, 117);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(77, 27);
            txtResultado.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(343, 23);
            label1.TabIndex = 12;
            label1.Text = "Representación correcta para operaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 311);
            label2.Name = "label2";
            label2.Size = new Size(343, 20);
            label2.TabIndex = 13;
            label2.Text = "Sin, Cos, Tan y Log (Todas inician con Mayúscula)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 331);
            label3.Name = "label3";
            label3.Size = new Size(238, 20);
            label3.TabIndex = 14;
            label3.Text = "Raíz = Sqrt (Inicia con mayúscula)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 351);
            label4.Name = "label4";
            label4.Size = new Size(363, 20);
            label4.TabIndex = 15;
            label4.Text = "El exponen se representa con ^n y si es x a la 1 es *x";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1, 20);
            label5.Name = "label5";
            label5.Size = new Size(386, 20);
            label5.TabIndex = 16;
            label5.Text = "Favor de escribir la función sin el f(x), g(x) entre otros";
            // 
            // frmsimpson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(rtbProcedimiento);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtSubintervalos);
            Controls.Add(lblSubintervalos);
            Controls.Add(txtLimiteSuperior);
            Controls.Add(lblLimiteSuperior);
            Controls.Add(txtLimiteInferior);
            Controls.Add(lblLimiteInferior);
            Controls.Add(txtFuncion);
            Controls.Add(lblFuncion);
            Name = "frmsimpson";
            Text = "frmsimpson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncion;
        private TextBox txtFuncion;
        private Label lblLimiteInferior;
        private TextBox txtLimiteInferior;
        private Label lblLimiteSuperior;
        private TextBox txtLimiteSuperior;
        private Label lblSubintervalos;
        private TextBox txtSubintervalos;
        private Button btnCalcular;
        private Label lblResultado;
        private RichTextBox rtbProcedimiento;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}