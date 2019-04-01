using System;
using Gtk;

namespace users
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            Escuela_manejo.MainWindow win = new Escuela_manejo.MainWindow();
            win.Show();
            Application.Run();
        }
    }
}

