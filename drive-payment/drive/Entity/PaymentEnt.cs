using System;
namespace drive.Entity
{
    public class PaymentEnt
    {
        private int id_payment;
        private int id_user;
        private int id_costumer;
        private int id_branch;
        private DateTime date;
        private int state;
        private float subtotal;
        private float total;
        private float iva;
        private string payment_method;

        public int Id_payment { get => id_payment; set => id_payment = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public int Id_costumer { get => id_costumer; set => id_costumer = value; }
        public int Id_branch { get => id_branch; set => id_branch = value; }
        public DateTime Date { get => date; set => date = value; }
        public int State { get => state; set => state = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }
        public float Total { get => total; set => total = value; }
        public float Iva { get => iva; set => iva = value; }
        public string Payment_method { get => payment_method; set => payment_method = value; }

    }
}
