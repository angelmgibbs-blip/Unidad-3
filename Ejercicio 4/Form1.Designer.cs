namespace Ejercicio_4
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
            TxtPalabra = new TextBox();
            BtnVerificar = new Button();
            SuspendLayout();
            // 
            // TxtPalabra
            // 
            TxtPalabra.Location = new Point(287, 113);
            TxtPalabra.Name = "TxtPalabra";
            TxtPalabra.Size = new Size(100, 23);
            TxtPalabra.TabIndex = 0;
            // 
            // BtnVerificar
            // 
            BtnVerificar.Location = new Point(287, 159);
            BtnVerificar.Name = "BtnVerificar";
            BtnVerificar.Size = new Size(100, 23);
            BtnVerificar.TabIndex = 1;
            BtnVerificar.Text = "Verificar";
            BtnVerificar.UseVisualStyleBackColor = true;
            BtnVerificar.Click += BtnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVerificar);
            Controls.Add(TxtPalabra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPalabra;
        private Button BtnVerificar;
    }
}
