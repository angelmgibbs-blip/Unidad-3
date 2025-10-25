using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_3._1.Entities
{
    internal class Alumno
    {
    //Constructor
    
    public Alumno() { }

     //Propiedades automaticas de los atributos
     public String Codigo { get; set; }
     public String Nombre { get; set; }
     public double Promedio { get; set; }

    }
}
