using System;
namespace Seguridad.entidades
{
    public class Tbl_rolOpcion
    {
        private int id_rolOpcion;
        private int id_rol;
        private int id_opcion;

        public Tbl_rolOpcion()
        {
        }

        public int Id_rolOpcion { get => id_rolOpcion; set => id_rolOpcion = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
        public int Id_opcion { get => id_opcion; set => id_opcion = value; }
    }
}
