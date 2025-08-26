namespace practico4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Ldesde = new Label();
            LHasta = new Label();
            TBDesde = new TextBox();
            TBHasta = new TextBox();
            BGenerarFuncion = new Button();
            label1 = new Label();
            LListaDeNumeros = new Label();
            TBListaNumeros = new TextBox();
            SuspendLayout();
            // 
            // Ldesde
            // 
            Ldesde.AutoSize = true;
            Ldesde.Location = new Point(73, 163);
            Ldesde.Name = "Ldesde";
            Ldesde.Size = new Size(39, 15);
            Ldesde.TabIndex = 0;
            Ldesde.Text = "Desde";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(75, 214);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 1;
            LHasta.Text = "Hasta";
            // 
            // TBDesde
            // 
            TBDesde.Location = new Point(140, 160);
            TBDesde.Multiline = true;
            TBDesde.Name = "TBDesde";
            TBDesde.Size = new Size(100, 23);
            TBDesde.TabIndex = 2;
            TBDesde.TextChanged += TBDesde_TextChanged;
            // 
            // TBHasta
            // 
            TBHasta.Location = new Point(140, 211);
            TBHasta.Name = "TBHasta";
            TBHasta.Size = new Size(100, 23);
            TBHasta.TabIndex = 3;
            TBHasta.TextChanged += TBHasta_TextChanged;
            // 
            // BGenerarFuncion
            // 
            BGenerarFuncion.BackColor = Color.Transparent;
            BGenerarFuncion.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            BGenerarFuncion.FlatStyle = FlatStyle.System;
            BGenerarFuncion.ForeColor = Color.Black;
            BGenerarFuncion.Location = new Point(302, 179);
            BGenerarFuncion.Name = "BGenerarFuncion";
            BGenerarFuncion.Size = new Size(122, 23);
            BGenerarFuncion.TabIndex = 4;
            BGenerarFuncion.Text = "Generar Función";
            BGenerarFuncion.UseVisualStyleBackColor = false;
            BGenerarFuncion.Click += BGenerarFuncion_Click;
            BGenerarFuncion.Enter += BGenerarFuncion_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-31, 247);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // LListaDeNumeros
            // 
            LListaDeNumeros.AutoSize = true;
            LListaDeNumeros.Location = new Point(561, 46);
            LListaDeNumeros.Name = "LListaDeNumeros";
            LListaDeNumeros.Size = new Size(99, 15);
            LListaDeNumeros.TabIndex = 6;
            LListaDeNumeros.Text = "Lista de Números";
            // 
            // TBListaNumeros
            // 
            TBListaNumeros.Location = new Point(460, 79);
            TBListaNumeros.Multiline = true;
            TBListaNumeros.Name = "TBListaNumeros";
            TBListaNumeros.ReadOnly = true;
            TBListaNumeros.Size = new Size(300, 306);
            TBListaNumeros.TabIndex = 7;
            TBListaNumeros.TextAlign = HorizontalAlignment.Center;
            TBListaNumeros.TextChanged += TBListaNumeros_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TBListaNumeros);
            Controls.Add(LListaDeNumeros);
            Controls.Add(label1);
            Controls.Add(BGenerarFuncion);
            Controls.Add(TBHasta);
            Controls.Add(TBDesde);
            Controls.Add(LHasta);
            Controls.Add(Ldesde);
            Name = "Form1";
            Text = "Formulario 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Ldesde;
        private Label LHasta;
        private TextBox TBDesde;
        private TextBox TBHasta;
        private Button BGenerarFuncion;
        private Label label1;
        private Label LListaDeNumeros;
        private TextBox TBListaNumeros;
    }
}
