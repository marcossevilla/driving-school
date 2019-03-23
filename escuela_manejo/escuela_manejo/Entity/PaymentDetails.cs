using System;
namespace escuela_manejo
{
    public class PaymentDetails
    {
        /*
         *  Detalle pago para facturar varios servicios
         */

        private int id_payment_details;
        private int id_payment;
        private int id_course_service;

        public int Id_payment_details { get => id_payment_details; set => id_payment_details = value; }
        public int Id_payment { get => id_payment; set => id_payment = value; }
        public int Id_course_service { get => id_course_service; set => id_course_service = value; }

        public PaymentDetails()
        {
        }
    }
}
