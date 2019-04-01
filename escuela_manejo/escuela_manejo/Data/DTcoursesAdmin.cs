using System;
using escuela_manejo.Connection;

namespace escuela_manejo.Data
{
    public class DTcoursesAdmin
    {
        public DTcoursesAdmin()
        {

            var conCoursesAd = new Connection.Connection();

            conCoursesAd.AbrirCOnexion();


        }
    }
}
