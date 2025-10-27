using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            //Registrar alumno
            alumnoController.Registrar(alumno);

            //Mostrar alumnos
            MostrarAlumnos(alumnoController.ListarTodo());

            limpiarCampos();
        }

        public void limpiarCampos()
            {
            tbcodigo.Clear();
            tbnombre.Clear();
            tbpromedio.Clear();
            Tbbuscar.Clear();
            }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            // Validacion de seleccion
            if(CGalumnos.SelectedRows.Count ==0)
                {
                    MessageBox.Show("Seleccione un registro para eliminar");
                    return;
                }
            //Obtener el codigo
            String codigo = CGalumnos.SelectedRows[0].Cells[0].Value.ToString();

            //Eliminar fila seleccion 
            alumnoController.Eliminar(codigo);

            //Mostrar
            MostrarAlumnos(alumnoController.ListarTodo());

        }

        private void Bordenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoController.Ordenar());
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            //validar campo
            if(Tbbuscar.Text == "")
            {
                MessageBox.Show("Ingrese el codigo a buscar");
            }

            String codigo = Tbbuscar.Text;

            // Mostrar los alumnos de busqueda
            MostrarAlumnos(alumnoController.BuscarPorCodigo(codigo));
        }
    }
}
