namespace ejercicio_3
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
            Vlabel1 = new Label();
            TxtEntrada = new TextBox();
            CmbUnidadOrigen = new ComboBox();
            Clabel1 = new Label();
            CmbUnidadDestino = new ComboBox();
            BtnConvertir = new Button();
            Rlabel1 = new Label();
            LblResultado = new Label();
            SuspendLayout();
            // 
            // Vlabel1
            // 
            Vlabel1.AutoSize = true;
            Vlabel1.Location = new Point(309, 90);
            Vlabel1.Name = "Vlabel1";
            Vlabel1.Size = new Size(36, 15);
            Vlabel1.TabIndex = 0;
            Vlabel1.Text = "Valor:";
            // 
            // TxtEntrada
            // 
            TxtEntrada.Location = new Point(271, 124);
            TxtEntrada.Name = "TxtEntrada";
            TxtEntrada.Size = new Size(121, 23);
            TxtEntrada.TabIndex = 1;
            // 
            // CmbUnidadOrigen
            // 
            CmbUnidadOrigen.FormattingEnabled = true;
            CmbUnidadOrigen.Items.AddRange(new object[] { "Metros", "", "", "Centímetros", "", "", "Pulgadas" });
            CmbUnidadOrigen.Location = new Point(271, 165);
            CmbUnidadOrigen.Name = "CmbUnidadOrigen";
            CmbUnidadOrigen.Size = new Size(121, 23);
            CmbUnidadOrigen.TabIndex = 2;
            // 
            // Clabel1
            // 
            Clabel1.AutoSize = true;
            Clabel1.Location = new Point(302, 205);
            Clabel1.Name = "Clabel1";
            Clabel1.Size = new Size(68, 15);
            Clabel1.TabIndex = 3;
            Clabel1.Text = "Convertir a:";
            // 
            // CmbUnidadDestino
            // 
            CmbUnidadDestino.FormattingEnabled = true;
            CmbUnidadDestino.Items.AddRange(new object[] { "Metros", "", "", "Centímetros", "", "", "Pulgadas" });
            CmbUnidadDestino.Location = new Point(271, 240);
            CmbUnidadDestino.Name = "CmbUnidadDestino";
            CmbUnidadDestino.Size = new Size(121, 23);
            CmbUnidadDestino.TabIndex = 4;
            // 
            // BtnConvertir
            // 
            BtnConvertir.Location = new Point(302, 297);
            BtnConvertir.Name = "BtnConvertir";
            BtnConvertir.Size = new Size(68, 23);
            BtnConvertir.TabIndex = 5;
            BtnConvertir.Text = "Convertir";
            BtnConvertir.UseVisualStyleBackColor = true;
            BtnConvertir.Click += BtnConvertir_Click;
            // 
            // Rlabel1
            // 
            Rlabel1.AutoSize = true;
            Rlabel1.Location = new Point(309, 370);
            Rlabel1.Name = "Rlabel1";
            Rlabel1.Size = new Size(62, 15);
            Rlabel1.TabIndex = 6;
            Rlabel1.Text = "Resultado:";
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(317, 411);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(28, 15);
            LblResultado.TabIndex = 7;
            LblResultado.Text = "0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResultado);
            Controls.Add(Rlabel1);
            Controls.Add(BtnConvertir);
            Controls.Add(CmbUnidadDestino);
            Controls.Add(Clabel1);
            Controls.Add(CmbUnidadOrigen);
            Controls.Add(TxtEntrada);
            Controls.Add(Vlabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Vlabel1;
        private TextBox TxtEntrada;
        private ComboBox CmbUnidadOrigen;
        private Label Clabel1;
        private ComboBox CmbUnidadDestino;
        private Button BtnConvertir;
        private Label Rlabel1;
        private Label LblResultado;
    }
}
