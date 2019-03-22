using System;
namespace Seguridad.entidades
{
    public class vwUserRol
    {
        private int id_user;
        private String user;
        private String nombres;
        private String apellidos;
        private String email;
        private int id_rol;
        private String rol;

        public vwUserRol()
        {

        }

        public int Id_user { get => id_user; set => id_user = value; }
        public string User { get => user; set => user = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
