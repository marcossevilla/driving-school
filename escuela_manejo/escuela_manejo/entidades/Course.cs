using System;
namespace escuela_manejo
{
    public class Course
    {
        /*
         *  class Course -> catalogo de cursos del negocio
         */

        private int id_course;
        private string name;
        private string description;

        public int Id_course { get => id_course; set => id_course = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public Course()
        {
        }
    }
}
