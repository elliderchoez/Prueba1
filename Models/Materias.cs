using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Models
{
    //Modelo donde estan las propiedades
    public class Materias
    {
        public int ID { get; set; }
        public string Dia { get; set; }
        //Agregamos propiedades nombre de materia
        public string Nombre { get; set; }        

        //Agregamos propiedades hora de materia
        public int Hora { get; set; }
    }
}
