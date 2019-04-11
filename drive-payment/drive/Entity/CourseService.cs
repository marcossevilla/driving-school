using System;
namespace drive.Entity
{
    public class CourseService
    {
        /*
         *  Cursos o servicios que van 
         *  a ser facturados
         */

        private int id_course_service;
        private int id_course_operating;
        private int id_service_type;
        private string name;
        private string description;
        private float price;
        private int state;

        public int Id_course_service { get => id_course_service; set => id_course_service = value; }
        public int Id_course_operating { get => id_course_operating; set => id_course_operating = value; }
        public int Id_service_type { get => id_service_type; set => id_service_type = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public float Price { get => price; set => price = value; }
        public int State { get => state; set => state = value; }

        public CourseService()
        {
        }
    }

}
