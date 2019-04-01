using System;
using Gtk;
using escuela_manejo.Main_forms;

namespace escuela_manejo{ 
class MainClass
    {
        public static void Main(string[] args)
        {
         
            Application.Init();

            Start win = new Start();
            win.Show();
            Application.Run();
          




        }
    }
}
