namespace practico5
{
    partial class Form1
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
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LSaldo = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBSaldo = new System.Windows.Forms.TextBox();
            this.TBFoto = new System.Windows.Forms.TextBox();
            this.BFoto = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cuadrosnegros = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadrosnegros)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(79, 53);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(96, 34);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(79, 112);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(104, 34);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNacimiento.Location = new System.Drawing.Point(79, 181);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(194, 34);
            this.LFechaNacimiento.TabIndex = 2;
            this.LFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.Location = new System.Drawing.Point(79, 237);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(74, 34);
            this.LSexo.TabIndex = 3;
            this.LSexo.Text = "Sexo:";
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSaldo.Location = new System.Drawing.Point(79, 295);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(82, 34);
            this.LSaldo.TabIndex = 4;
            this.LSaldo.Text = "Saldo:";
            this.LSaldo.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(216, 61);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(305, 20);
            this.TBNombre.TabIndex = 5;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(216, 120);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(305, 20);
            this.TBApellido.TabIndex = 6;
            // 
            // TBSaldo
            // 
            this.TBSaldo.Location = new System.Drawing.Point(216, 303);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.Size = new System.Drawing.Size(305, 20);
            this.TBSaldo.TabIndex = 7;
            // 
            // TBFoto
            // 
            this.TBFoto.Location = new System.Drawing.Point(216, 350);
            this.TBFoto.Name = "TBFoto";
            this.TBFoto.Size = new System.Drawing.Size(305, 20);
            this.TBFoto.TabIndex = 8;
            // 
            // BFoto
            // 
            this.BFoto.Location = new System.Drawing.Point(85, 347);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(75, 23);
            this.BFoto.TabIndex = 9;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(289, 400);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 10;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.Location = new System.Drawing.Point(225, 246);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(62, 17);
            this.RBHombre.TabIndex = 11;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = true;
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(313, 246);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 11;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::practico5.Properties.Resources.avatar;
            this.pictureBox1.Image = global::practico5.Properties.Resources.avatar;
            this.pictureBox1.InitialImage = global::practico5.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(557, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cuadrosnegros
            // 
            this.cuadrosnegros.Image = global::practico5.Properties.Resources.cuadros_negros;
            this.cuadrosnegros.Location = new System.Drawing.Point(28, 21);
            this.cuadrosnegros.Name = "cuadrosnegros";
            this.cuadrosnegros.Size = new System.Drawing.Size(863, 479);
            this.cuadrosnegros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cuadrosnegros.TabIndex = 13;
            this.cuadrosnegros.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 531);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBHombre);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.BFoto);
            this.Controls.Add(this.TBFoto);
            this.Controls.Add(this.TBSaldo);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LSaldo);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.LFechaNacimiento);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.cuadrosnegros);
            this.Name = "Form1";
            this.Text = "Formulario con DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadrosnegros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBSaldo;
        private System.Windows.Forms.TextBox TBFoto;
        private System.Windows.Forms.Button BFoto;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cuadrosnegros;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

