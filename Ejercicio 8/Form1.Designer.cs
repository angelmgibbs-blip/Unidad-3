namespace Ejercicio_8
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
            TxtOracion = new TextBox();
            BtnContar = new Button();
            LblResultado = new Label();
            SuspendLayout();
            // 
            // TxtOracion
            // 
            TxtOracion.Location = new Point(159, 49);
            TxtOracion.Name = "TxtOracion";
            TxtOracion.Size = new Size(246, 23);
            TxtOracion.TabIndex = 0;
            // 
            // BtnContar
            // 
            BtnContar.Location = new Point(241, 112);
            BtnContar.Name = "BtnContar";
            BtnContar.Size = new Size(75, 23);
            BtnContar.TabIndex = 1;
            BtnContar.Text = "Contar Palabras";
            BtnContar.UseVisualStyleBackColor = true;
            BtnContar.Click += BtnContar_Click;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(278, 178);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(13, 15);
            LblResultado.TabIndex = 2;
            LblResultado.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResultado);
            Controls.Add(BtnContar);
            Controls.Add(TxtOracion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtOracion;
        private Button BtnContar;
        private Label LblResultado;
    }
}
