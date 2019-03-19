using System;
namespace escuela_manejo
{
    public class ServiceType
    {
        /*
         *  Tipo de servicio para clasificar como
         *  curso o como servicio aparte
         */

        private int id_payment_details;
        private int id_payment;
        private int course_service;

        public int Id_payment_details { get => id_payment_details; set => id_payment_details = value; }
        public int Id_payment { get => id_payment; set => id_payment = value; }
        public int Course_service { get => course_service; set => course_service = value; }

        public ServiceType()
        {
        }
    }
}
