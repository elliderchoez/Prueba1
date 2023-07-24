using Prueba1.Models;
using System;
using System.Collections.Generic;

namespace Prueba1.CAL
{
    //clase MateriaService que hereda de IMateriaService
    public class MateriaService : IMateriasService
    {
        public List<Materias> GetMaterias()
        {
            var Materia = new List<Materias>();

            
            Materia.Add(new Materias()
            {
                ID = 1,
                Dia= "Lunes",
                Nombre = "POO",
                Hora = 08,
            });

            Materia.Add(new Materias()
            {
                ID = 2,
                Dia = "Lunes",
                Nombre = "Sistemas Operativos",
                Hora = 10,
            }); ;

            Materia.Add(new Materias()
            {
                ID = 3,
                Dia = "Martes",
                Nombre = "Organizacion y Arquitectura de un computador",
                Hora = 08,
            });

            Materia.Add(new Materias()
            {
                ID = 4,
                Dia = "Martes",
                Nombre = "Metodos y tecnicas de la investigacion",
                Hora = 10,
            });


            Materia.Add(new Materias()
            {
                ID = 5,
                Dia = "Miercoles",
                Nombre = "Sistemas Digitales",
                Hora = 08,
            });

            Materia.Add(new Materias()
            {
                ID = 6,
                Dia = "Miercoles",
                Nombre = "Ecuaciones Diferenciales",
                Hora = 10,
            });


            Materia.Add(new Materias()
            {
                ID = 2,
                Dia = "Jueves",
                Nombre = "Sistemas Operativos",
                Hora = 08,
            });

            Materia.Add(new Materias()
            {
                ID = 1,
                Dia = "Lunes",
                Nombre = "POO",
                Hora = 10,
            });

            Materia.Add(new Materias()
            {
                ID = 6,
                Dia = "viernes",
                Nombre = "Ecuaciones Diferenciales",
                Hora = 08,
            });

            Materia.Add(new Materias()
            {
                ID = 5,
                Dia = "Viernes",
                Nombre = "Sistemas Digitales",
                Hora = 10,
            });

            return Materia;
        }
    }
}
