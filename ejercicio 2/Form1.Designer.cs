namespace ejercicio_2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TxtMinutos = new TextBox();
            label2 = new Label();
            TxtSegundos = new TextBox();
            BtnIniciar = new Button();
            BtnDetener = new Button();
            LblTiempoRestante = new Label();
            timerReloj = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Minutos";
            // 
            // TxtMinutos
            // 
            TxtMinutos.Location = new Point(30, 57);
            TxtMinutos.Name = "TxtMinutos";
            TxtMinutos.Size = new Size(100, 23);
            TxtMinutos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 39);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Segundos";
            // 
            // TxtSegundos
            // 
            TxtSegundos.Location = new Point(247, 57);
            TxtSegundos.Name = "TxtSegundos";
            TxtSegundos.Size = new Size(100, 23);
            TxtSegundos.TabIndex = 3;
            // 
            // BtnIniciar
            // 
            BtnIniciar.Location = new Point(71, 159);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(75, 23);
            BtnIniciar.TabIndex = 4;
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // BtnDetener
            // 
            BtnDetener.Location = new Point(227, 159);
            BtnDetener.Name = "BtnDetener";
            BtnDetener.Size = new Size(75, 23);
            BtnDetener.TabIndex = 5;
            BtnDetener.Text = "Detener";
            BtnDetener.UseVisualStyleBackColor = true;
            BtnDetener.Click += BtnDetener_Click;
            // 
            // LblTiempoRestante
            // 
            LblTiempoRestante.AutoSize = true;
            LblTiempoRestante.Location = new Point(173, 108);
            LblTiempoRestante.Name = "LblTiempoRestante";
            LblTiempoRestante.Size = new Size(34, 15);
            LblTiempoRestante.TabIndex = 6;
            LblTiempoRestante.Text = "00:00";
            // 
            // timerReloj
            // 
            timerReloj.Interval = 1000;
            timerReloj.Tick += timerReloj_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblTiempoRestante);
            Controls.Add(BtnDetener);
            Controls.Add(BtnIniciar);
            Controls.Add(TxtSegundos);
            Controls.Add(label2);
            Controls.Add(TxtMinutos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtMinutos;
        private Label label2;
        private TextBox TxtSegundos;
        private Button BtnIniciar;
        private Button BtnDetener;
        private Label LblTiempoRestante;
        private System.Windows.Forms.Timer timerReloj;
    }
}
