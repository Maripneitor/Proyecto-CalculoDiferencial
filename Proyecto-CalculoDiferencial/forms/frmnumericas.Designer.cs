namespace Proyecto_CalculoDiferencial.forms
{
    partial class frmnumericas
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
            label1 = new Label();
            FuncionDN = new TextBox();
            label2 = new Label();
            ValorX = new TextBox();
            CalcularDV = new Button();
            label3 = new Label();
            ResultadoFinal = new Label();
            VerProcedimiento = new Button();
            ProcedimientoDN = new Label();
            BorrarDT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 17);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Funcion:";
            // 
            // FuncionDN
            // 
            FuncionDN.Location = new Point(148, 17);
            FuncionDN.Name = "FuncionDN";
            FuncionDN.Size = new Size(158, 27);
            FuncionDN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 74);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 2;
            label2.Text = "Valor de x:";
            // 
            // ValorX
            // 
            ValorX.Location = new Point(148, 74);
            ValorX.Name = "ValorX";
            ValorX.Size = new Size(158, 27);
            ValorX.TabIndex = 3;
            // 
            // CalcularDV
            // 
            CalcularDV.Cursor = Cursors.Hand;
            CalcularDV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalcularDV.Location = new Point(121, 130);
            CalcularDV.Name = "CalcularDV";
            CalcularDV.Size = new Size(117, 45);
            CalcularDV.TabIndex = 4;
            CalcularDV.Text = "CALCULAR";
            CalcularDV.UseVisualStyleBackColor = true;
            CalcularDV.Click += CalcularDV_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 339);
            label3.Name = "label3";
            label3.Size = new Size(130, 28);
            label3.TabIndex = 5;
            label3.Text = "RESULTADO:";
            // 
            // ResultadoFinal
            // 
            ResultadoFinal.AutoSize = true;
            ResultadoFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultadoFinal.Location = new Point(241, 339);
            ResultadoFinal.Name = "ResultadoFinal";
            ResultadoFinal.Size = new Size(23, 28);
            ResultadoFinal.TabIndex = 6;
            ResultadoFinal.Text = "0";
            // 
            // VerProcedimiento
            // 
            VerProcedimiento.Cursor = Cursors.Hand;
            VerProcedimiento.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerProcedimiento.Location = new Point(78, 195);
            VerProcedimiento.Name = "VerProcedimiento";
            VerProcedimiento.Size = new Size(203, 45);
            VerProcedimiento.TabIndex = 7;
            VerProcedimiento.Text = "VER PROCEDIMIENTO";
            VerProcedimiento.UseVisualStyleBackColor = true;
            VerProcedimiento.Click += VerProcedimiento_Click;
            // 
            // ProcedimientoDN
            // 
            ProcedimientoDN.AutoSize = true;
            ProcedimientoDN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProcedimientoDN.Location = new Point(446, 17);
            ProcedimientoDN.Name = "ProcedimientoDN";
            ProcedimientoDN.Size = new Size(152, 28);
            ProcedimientoDN.TabIndex = 8;
            ProcedimientoDN.Text = "Procedimiento...";
            // 
            // BorrarDT
            // 
            BorrarDT.Cursor = Cursors.Hand;
            BorrarDT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BorrarDT.Location = new Point(121, 259);
            BorrarDT.Name = "BorrarDT";
            BorrarDT.Size = new Size(117, 45);
            BorrarDT.TabIndex = 9;
            BorrarDT.Text = "BORRAR";
            BorrarDT.UseVisualStyleBackColor = true;
            BorrarDT.Click += BorrarDT_Click;
            // 
            // frmnumericas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BorrarDT);
            Controls.Add(ProcedimientoDN);
            Controls.Add(VerProcedimiento);
            Controls.Add(ResultadoFinal);
            Controls.Add(label3);
            Controls.Add(CalcularDV);
            Controls.Add(ValorX);
            Controls.Add(label2);
            Controls.Add(FuncionDN);
            Controls.Add(label1);
            Name = "frmnumericas";
            Text = "frmnumericas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FuncionDN;
        private Label label2;
        private TextBox ValorX;
        private Button CalcularDV;
        private Label label3;
        private Label ResultadoFinal;
        private Button VerProcedimiento;
        private Label ProcedimientoDN;
        private Button BorrarDT;
    }
}