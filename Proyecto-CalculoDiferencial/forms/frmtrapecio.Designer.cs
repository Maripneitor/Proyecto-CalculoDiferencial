namespace Proyecto_CalculoDiferencial.forms
{
    partial class frmtrapecio
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
            txtlimiteinferior = new TextBox();
            txtlimitesuperior = new TextBox();
            txtintervalo = new TextBox();
            btncalcular = new FontAwesome.Sharp.IconButton();
            lbresultado = new Label();
            lblimiteinferior = new Label();
            lblimitesuperior = new Label();
            lbintervalo = new Label();
            txtfuncion = new TextBox();
            lbfuncion1 = new Label();
            listBoxPasos = new ListBox();
            SuspendLayout();
            // 
            // txtlimiteinferior
            // 
            txtlimiteinferior.Location = new Point(187, 49);
            txtlimiteinferior.Name = "txtlimiteinferior";
            txtlimiteinferior.Size = new Size(155, 27);
            txtlimiteinferior.TabIndex = 0;
            // 
            // txtlimitesuperior
            // 
            txtlimitesuperior.Location = new Point(185, 102);
            txtlimitesuperior.Name = "txtlimitesuperior";
            txtlimitesuperior.Size = new Size(157, 27);
            txtlimitesuperior.TabIndex = 1;
            // 
            // txtintervalo
            // 
            txtintervalo.Location = new Point(241, 149);
            txtintervalo.Name = "txtintervalo";
            txtintervalo.Size = new Size(101, 27);
            txtintervalo.TabIndex = 2;
            // 
            // btncalcular
            // 
            btncalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btncalcular.IconColor = Color.Black;
            btncalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncalcular.IconSize = 30;
            btncalcular.Location = new Point(77, 358);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(109, 54);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Font = new Font("Segoe UI", 12F);
            lbresultado.Location = new Point(77, 297);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(133, 28);
            lbresultado.TabIndex = 4;
            lbresultado.Text = "Resultado: 0.0";
            // 
            // lblimiteinferior
            // 
            lblimiteinferior.AutoSize = true;
            lblimiteinferior.Font = new Font("Segoe UI", 12F);
            lblimiteinferior.Location = new Point(46, 45);
            lblimiteinferior.Name = "lblimiteinferior";
            lblimiteinferior.Size = new Size(133, 28);
            lblimiteinferior.TabIndex = 5;
            lblimiteinferior.Text = "Limite inferior";
            // 
            // lblimitesuperior
            // 
            lblimitesuperior.AutoSize = true;
            lblimitesuperior.Font = new Font("Segoe UI", 12F);
            lblimitesuperior.Location = new Point(34, 102);
            lblimitesuperior.Name = "lblimitesuperior";
            lblimitesuperior.Size = new Size(145, 28);
            lblimitesuperior.TabIndex = 6;
            lblimitesuperior.Text = "Limite Superior";
            lblimitesuperior.Click += label1_Click;
            // 
            // lbintervalo
            // 
            lbintervalo.AutoSize = true;
            lbintervalo.Font = new Font("Segoe UI", 12F);
            lbintervalo.Location = new Point(34, 145);
            lbintervalo.Name = "lbintervalo";
            lbintervalo.Size = new Size(201, 28);
            lbintervalo.TabIndex = 7;
            lbintervalo.Text = "Numero de Intervalos";
            // 
            // txtfuncion
            // 
            txtfuncion.Location = new Point(241, 206);
            txtfuncion.Name = "txtfuncion";
            txtfuncion.Size = new Size(100, 27);
            txtfuncion.TabIndex = 8;
            // 
            // lbfuncion1
            // 
            lbfuncion1.AutoSize = true;
            lbfuncion1.Font = new Font("Segoe UI", 12F);
            lbfuncion1.Location = new Point(134, 202);
            lbfuncion1.Name = "lbfuncion1";
            lbfuncion1.Size = new Size(85, 28);
            lbfuncion1.TabIndex = 9;
            lbfuncion1.Text = "Funcion:";
            // 
            // listBoxPasos
            // 
            listBoxPasos.FormattingEnabled = true;
            listBoxPasos.Location = new Point(506, 65);
            listBoxPasos.Name = "listBoxPasos";
            listBoxPasos.Size = new Size(373, 384);
            listBoxPasos.TabIndex = 10;
            listBoxPasos.SelectedIndexChanged += listBoxPasos_SelectedIndexChanged;
            // 
            // frmtrapecio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 491);
            Controls.Add(listBoxPasos);
            Controls.Add(lbfuncion1);
            Controls.Add(txtfuncion);
            Controls.Add(lbintervalo);
            Controls.Add(lblimitesuperior);
            Controls.Add(lblimiteinferior);
            Controls.Add(lbresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtintervalo);
            Controls.Add(txtlimitesuperior);
            Controls.Add(txtlimiteinferior);
            Name = "frmtrapecio";
            Text = "frmtrapecio";
            Load += frmtrapecio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlimiteinferior;
        private TextBox txtlimitesuperior;
        private TextBox txtintervalo;
        private FontAwesome.Sharp.IconButton btncalcular;
        private Label lbresultado;
        private Label lblimiteinferior;
        private Label lblimitesuperior;
        private Label lbintervalo;
        private TextBox txtfuncion;
        private Label lbfuncion1;
        private ListBox listBoxPasos;
    }
}