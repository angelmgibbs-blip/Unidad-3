using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_3._1.Controllers;
using Unidad_3._1.Entities;

namespace Unidad_3._1
{
    //Llamar al controlador
    public partial class Form1 : Form
    {
        private AlumnoController alumnoController = new AlumnoController();

        public Form1()
        {
            InitializeComponent();
        }

        //Mostrar
        private void MostrarAlumnos(Alumno[] alumnos)
        {
            CGalumnos.DataSource = null;
            CGalumnos.DataSource = alumnos;
        }

        private void Bregistrar_Click(object sender, EventArgs e)
        {
//validar campo
if(tbcodigo.Text == " " || tbnombre.Text == " " || tbpromedio.Text == " ")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            //crear alumno
            Alumno alumno = new Alumno()
            {
                Codigo = tbcodigo.Text,
                Nombre = tbnombre.Text,
                Promedio = double.Parse(tbpromedio.Text)
            };
}
    }
    }
