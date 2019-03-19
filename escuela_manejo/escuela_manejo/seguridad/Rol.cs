using System;
namespace escuela_manejo
{
    public class Rol
    {
        private int id_rol;
        private string rol;
        private int state;

        public int Id_rol { get => id_rol; set => id_rol = value; }
        public string Rol { get => rol; set => rol = value; }
        public int State { get => state; set => state = value; }

        public Rol()
        {
        }
    }
}
