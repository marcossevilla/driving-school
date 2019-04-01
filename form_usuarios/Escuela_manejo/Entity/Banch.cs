using System;
namespace Escuela_manejo.NewFolder
{
    public class Banch
    {
        /*
         *  class Branch -> sucursales del negocio
          */
         
        private int id_branch_int;
        private string ruc;
        private string name;
        private string address;
        private string phone;
        private string printing_business;   // # de imprenta

        public int Id_branch_int { get => id_branch_int; set => id_branch_int = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Printing_business { get => printing_business; set => printing_business = value; }

        public Banch()
        {
        }

    }
}
