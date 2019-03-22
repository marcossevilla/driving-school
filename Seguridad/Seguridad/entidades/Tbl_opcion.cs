using System;
namespace Seguridad.entidades
{
    public class Tbl_opcion
    {
        private int id_opcion;
        private String opcion;
        private int estado;


        public Tbl_opcion()
        {

        }

        public int Id_opcion { get => id_opcion; set => id_opcion = value; }
        public string Opcion { get => opcion; set => opcion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
