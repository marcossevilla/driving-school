using System;
namespace escuela_manejo
{
    public class RolOption
    {
        private int id_rol_opcion;
        private int id_rol;
        private int id_opcion;

        public int Id_rol_opcion { get => id_rol_opcion; set => id_rol_opcion = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
        public int Id_opcion { get => id_opcion; set => id_opcion = value; }

        public RolOption()
        {
        }
    }
}
