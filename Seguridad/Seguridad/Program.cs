using System;
using Gtk;

namespace Seguridad
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            entidades.Tbl_user tu = new entidades.Tbl_user();
            tu.Nombres = "Elliot Fermin";
            tu.Apellidos = "Williamson Sandoval";
            */

            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
            /*Console.WriteLine("Nombres: " + tu.Nombres + "Apellidos: " + tu.Apellidos);*/
            /* Datos.Connection contest = new Datos.Connection();
             contest.AbrirCOnexion();*/

          



           }
        }
}
