namespace WinForms_eje_3
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
            label1 = new Label();
            txtNumero = new TextBox();
            lstTabla = new ListBox();
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 43);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa un número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(321, 85);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            txtNumero.Text = "0";
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(301, 226);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(120, 94);
            lstTabla.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(282, 157);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(161, 23);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Tabla";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerar);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox txtNumero;
        private ListBox lstTabla;
        private Button btnGenerar;
    }
}
