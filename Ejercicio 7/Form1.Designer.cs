namespace Ejercicio_7
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
            TxtInicio = new TextBox();
            TxtFin = new TextBox();
            BtnGenerarPrimos = new Button();
            LbPrimos = new ListBox();
            Ilabel1 = new Label();
            Flabel2 = new Label();
            SuspendLayout();
            // 
            // TxtInicio
            // 
            TxtInicio.Location = new Point(135, 12);
            TxtInicio.Name = "TxtInicio";
            TxtInicio.Size = new Size(100, 23);
            TxtInicio.TabIndex = 0;
            // 
            // TxtFin
            // 
            TxtFin.Location = new Point(135, 68);
            TxtFin.Name = "TxtFin";
            TxtFin.Size = new Size(100, 23);
            TxtFin.TabIndex = 1;
            // 
            // BtnGenerarPrimos
            // 
            BtnGenerarPrimos.Location = new Point(253, 42);
            BtnGenerarPrimos.Name = "BtnGenerarPrimos";
            BtnGenerarPrimos.Size = new Size(133, 23);
            BtnGenerarPrimos.TabIndex = 2;
            BtnGenerarPrimos.Text = "Generar Primos";
            BtnGenerarPrimos.UseVisualStyleBackColor = true;
            BtnGenerarPrimos.Click += BtnGenerarPrimos_Click;
            // 
            // LbPrimos
            // 
            LbPrimos.FormattingEnabled = true;
            LbPrimos.ItemHeight = 15;
            LbPrimos.Location = new Point(473, 12);
            LbPrimos.Name = "LbPrimos";
            LbPrimos.Size = new Size(120, 109);
            LbPrimos.TabIndex = 3;
            // 
            // Ilabel1
            // 
            Ilabel1.AutoSize = true;
            Ilabel1.Location = new Point(73, 15);
            Ilabel1.Name = "Ilabel1";
            Ilabel1.Size = new Size(39, 15);
            Ilabel1.TabIndex = 4;
            Ilabel1.Text = "Inicio:";
            // 
            // Flabel2
            // 
            Flabel2.AutoSize = true;
            Flabel2.Location = new Point(73, 76);
            Flabel2.Name = "Flabel2";
            Flabel2.Size = new Size(26, 15);
            Flabel2.TabIndex = 5;
            Flabel2.Text = "Fin:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Flabel2);
            Controls.Add(Ilabel1);
            Controls.Add(LbPrimos);
            Controls.Add(BtnGenerarPrimos);
            Controls.Add(TxtFin);
            Controls.Add(TxtInicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtInicio;
        private TextBox TxtFin;
        private Button BtnGenerarPrimos;
        private ListBox LbPrimos;
        private Label label1;
        private Label Flabel2;
        private Label Ilabel1;
    }
}
