using System;
namespace escuela_manejo
{
    public class UserRol
    {
        private int id_user_rol;
        private int id_user;
        private int id_rol;

        public int Id_user_rol { get => id_user_rol; set => id_user_rol = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }

        public UserRol()
        {
        }
    }
}
