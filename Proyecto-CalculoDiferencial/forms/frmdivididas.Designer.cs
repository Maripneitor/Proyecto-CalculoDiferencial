namespace Proyecto_CalculoDiferencial.forms
{
    partial class frmdivididas
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
            btnCalcular = new Button();
            txtResultados = new RichTextBox();
            pictureBoxFuncion = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFuncion).BeginInit();
            SuspendLayout();
            // 
            // txtFuncion
            // 
            txtFuncion.BackColor = Color.Turquoise;
            txtFuncion.Location = new Point(73, 99);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(205, 27);
            txtFuncion.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(86, 147);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(171, 55);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultados
            // 
            txtResultados.BackColor = Color.Cyan;
            txtResultados.Location = new Point(12, 208);
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(351, 157);
            txtResultados.TabIndex = 2;
            txtResultados.Text = "";
            // 
            // pictureBoxFuncion
            // 
            pictureBoxFuncion.Location = new Point(389, 12);
            pictureBoxFuncion.Name = "pictureBoxFuncion";
            pictureBoxFuncion.Size = new Size(480, 426);
            pictureBoxFuncion.TabIndex = 3;
            pictureBoxFuncion.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkTurquoise;
            label1.Location = new Point(114, 58);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese la funcion";
            // 
            // frmdivididas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(881, 450);
            Controls.Add(label1);
            Controls.Add(pictureBoxFuncion);
            Controls.Add(txtResultados);
            Controls.Add(btnCalcular);
            Controls.Add(txtFuncion);
            Name = "frmdivididas";
            Text = "frmdivididas";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFuncion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFuncion;
        private Button btnCalcular;
        private RichTextBox txtResultados;
        private PictureBox pictureBoxFuncion;
        private Label label1;
    }
}