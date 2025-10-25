using System;
using System.Collections;
using Unidad_3._1.Entities;

namespace Unidad_3._1.Controllers
{
    internal class AlumnoController
    {
        //Arreglo 
        private Alumno[] alumnos = new Alumno[100];
        private int cont = 0;

        //Listar Todos los alumnos
        public Alumno[] ListarTodo() { return alumnos; }

        //Registrar alumnos
        public void Registrar(Alumno alumno)
        {
            alumnos[cont] = alumno;
            cont++;
        }
//Eliminar alumnos del arregro
public void Eliminar(string codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno.Codigo == codigo);
       
        // Logica de eliminacion
        for (int i =0; i < cont; i++)
         {
                if (i >= posicion)
            {
                    alumnos[i] = alumnos[i + 1];
                }
            }
            cont--;
     }
        //Metodo comparacion
        private class MetodoComparacion: IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (((Alumno)x).Promedio < ((Alumno)y).Promedio) return -1; else if (((Alumno)x).Promedio == ((Alumno)y).Promedio) return 0; else return 1;
            }
        }
    public Alumno[] Ordenar()
        {
            Array.Sort(alumnos, 0, cont, new MetodoComparacion());
            return alumnos;
}
    // Buscar alumno segun su codigo
    public Alumno[] BuscarPorCodigo(String codigo) {
            return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo.Contains(codigo));
}
    }

}
