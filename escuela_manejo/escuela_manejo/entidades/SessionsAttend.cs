using System;
namespace escuela_manejo
{
    public class SessionsAttend
    {
        /*
         *  Asistencia por sesion del curso
         */

        private int id_sessions_attend;
        private int id_course_operating;
        private DateTime start_datetime;
        private DateTime end_datetime;
        private string state;

        public int Id_sessions_attend { get => id_sessions_attend; set => id_sessions_attend = value; }
        public int Id_course_operating { get => id_course_operating; set => id_course_operating = value; }
        public DateTime Start_datemine { get => start_datetime; set => start_datetime = value; }
        public DateTime End_datemine { get => end_datetime; set => end_datetime = value; }
        public string State { get => state; set => state = value; }

        public SessionsAttend()
        {
        }
    }
}
