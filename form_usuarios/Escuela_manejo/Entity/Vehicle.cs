using System;
namespace users.Entity
{
    public class Vehicle
    {
        private int id_vehicle;
        private string model;
        private string brand;
        private string plate;
        private string color;
        private int state;

        public int Id_vehicle { get => id_vehicle; set => id_vehicle = value; }
        public string Model { get => model; set => model = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Plate { get => plate; set => plate = value; }
        public string Color { get => color; set => color = value; }
        public int State { get => state; set => state = value; }

        public Vehicle()
        {
        }

    }
}
