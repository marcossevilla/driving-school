using System;
namespace escuela_manejo
{
    public class Option
    {
        private int id_opcion;
        private string opcion;
        private int state;

        public int Id_opcion { get => id_opcion; set => id_opcion = value; }
        public string Opcion { get => opcion; set => opcion = value; }
        public int State { get => state; set => state = value; }

        public Option()
        {
        }
    }
}
