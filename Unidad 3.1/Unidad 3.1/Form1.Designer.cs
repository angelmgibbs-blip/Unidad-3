namespace Unidad_3._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbpromedio = new System.Windows.Forms.TextBox();
            this.Bregistrar = new System.Windows.Forms.Button();
            this.Beliminar = new System.Windows.Forms.Button();
            this.Bordenar = new System.Windows.Forms.Button();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbbuscar = new System.Windows.Forms.TextBox();
            this.CGalumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CGalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(180, 12);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Promedio";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(51, 8);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(121, 20);
            this.tbcodigo.TabIndex = 3;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(265, 5);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(175, 20);
            this.tbnombre.TabIndex = 4;
            // 
            // tbpromedio
            // 
            this.tbpromedio.Location = new System.Drawing.Point(537, 1);
            this.tbpromedio.Name = "tbpromedio";
            this.tbpromedio.Size = new System.Drawing.Size(121, 20);
            this.tbpromedio.TabIndex = 5;
            // 
            // Bregistrar
            // 
            this.Bregistrar.Location = new System.Drawing.Point(76, 84);
            this.Bregistrar.Name = "Bregistrar";
            this.Bregistrar.Size = new System.Drawing.Size(75, 23);
            this.Bregistrar.TabIndex = 6;
            this.Bregistrar.Text = "Registrar";
            this.Bregistrar.UseVisualStyleBackColor = true;
            this.Bregistrar.Click += new System.EventHandler(this.Bregistrar_Click);
            // 
            // Beliminar
            // 
            this.Beliminar.Location = new System.Drawing.Point(245, 84);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.Size = new System.Drawing.Size(75, 23);
            this.Beliminar.TabIndex = 7;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.UseVisualStyleBackColor = true;
            // 
            // Bordenar
            // 
            this.Bordenar.Location = new System.Drawing.Point(397, 83);
            this.Bordenar.Name = "Bordenar";
            this.Bordenar.Size = new System.Drawing.Size(75, 23);
            this.Bordenar.TabIndex = 8;
            this.Bordenar.Text = "Ordenar";
            this.Bordenar.UseVisualStyleBackColor = true;
            // 
            // Bbuscar
            // 
            this.Bbuscar.Location = new System.Drawing.Point(569, 83);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(75, 23);
            this.Bbuscar.TabIndex = 9;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar por Codigo";
            // 
            // Tbbuscar
            // 
            this.Tbbuscar.Location = new System.Drawing.Point(317, 160);
            this.Tbbuscar.Name = "Tbbuscar";
            this.Tbbuscar.Size = new System.Drawing.Size(100, 20);
            this.Tbbuscar.TabIndex = 11;
            // 
            // CGalumnos
            // 
            this.CGalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CGalumnos.Location = new System.Drawing.Point(125, 227);
            this.CGalumnos.Name = "CGalumnos";
            this.CGalumnos.Size = new System.Drawing.Size(533, 180);
            this.CGalumnos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CGalumnos);
            this.Controls.Add(this.Tbbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.Bordenar);
            this.Controls.Add(this.Beliminar);
            this.Controls.Add(this.Bregistrar);
            this.Controls.Add(this.tbpromedio);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "for v";
            ((System.ComponentModel.ISupportInitialize)(this.CGalumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbpromedio;
        private System.Windows.Forms.Button Bregistrar;
        private System.Windows.Forms.Button Beliminar;
        private System.Windows.Forms.Button Bordenar;
        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbbuscar;
        private System.Windows.Forms.DataGridView CGalumnos;
    }
}

