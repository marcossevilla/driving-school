using System;
namespace Escuela_manejo.entidades
{
    public class CourseOperating
    {
        /*
         *  Cursos en operacion/cursos activos
         */

        private int id_course_operating;
        private int id_course;
        private int id_instructor;
        private int id_vehicle;
        private int id_customer;
        private DateTime start_date;
        private DateTime end_date;

        public int Id_course_operating { get => id_course_operating; set => id_course_operating = value; }
        public int Id_course { get => id_course; set => id_course = value; }
        public int Id_instructor { get => id_instructor; set => id_instructor = value; }
        public int Id_vehicle { get => id_vehicle; set => id_vehicle = value; }
        public int Id_customer { get => id_customer; set => id_customer = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }

        public CourseOperating()
        {
        }

    }
}
