using System;
namespace escuela_manejo
{
    public class CreditCardPayment
    {
        private int id_credit_card_payment;
        private int card_first_digits;
        private int id_payment;
        private string name_on_card;
        private DateTime exp_date;
        private DateTime start_date;

        public int Id_credit_card_payment { get => id_credit_card_payment; set => id_credit_card_payment = value; }
        public int Card_first_digits { get => card_first_digits; set => card_first_digits = value; }
        public int Id_payment { get => id_payment; set => id_payment = value; }
        public string Name_on_card { get => name_on_card; set => name_on_card = value; }
        public DateTime Exp_date { get => exp_date; set => exp_date = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }

        public CreditCardPayment()
        {
        }
    }
}
