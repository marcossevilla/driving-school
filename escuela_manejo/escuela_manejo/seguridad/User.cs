using System;
namespace escuela_manejo
{
    public class User
    {
        private int id_user;
        private string id;
        private string username;
        private string pwd;
        private string first_name;
        private string last_name;
        private string email;
        private string pwd_temp;
        private int state;
        private string phone;
        private DateTime start_date;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string Pwd_temp { get => pwd_temp; set => pwd_temp = value; }
        public int State { get => state; set => state = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }


        public User()
        {
        }
    }
}
