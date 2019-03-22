using System;
namespace Seguridad.entidades
{
    public class Tbl_userRol
    {
        private int id_userRol;
        private int id_user;
        private int id_rol;

        public Tbl_userRol()
        {
        }

        public int Id_userRol { get => id_userRol; set => id_userRol = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
    }
}
