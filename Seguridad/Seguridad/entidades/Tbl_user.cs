using System;

namespace Seguridad.entidades
{
    public class Tbl_user
    {
        //Atributos
        private int id_user;
        private String user;
        private String pwd;
        private String nombres;
        private String apellidos;
        private String email;
        private String pwd_temp;
        private int estado;


        public Tbl_user()
        {

        }

        public Tbl_user(int id_user, string user, string pwd, string nombres, string apellidos, string email, string pwd_temp, int estado)
        {
            this.id_user = id_user;
            this.user = user;
            this.pwd = pwd;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.pwd_temp = pwd_temp;
            this.estado = estado;
        }

        public int Id_user { get => id_user; set => id_user = value; }
        public string User { get => user; set => user = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Pwd_temp { get => pwd_temp; set => pwd_temp = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
