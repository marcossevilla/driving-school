using System;
using Gtk;
using escuela_manejo.Main_forms;

namespace escuela_manejo{ 
class MainClass
    {
        public static void Main(string[] args)
        {
         
            Application.Init();

            Main_forms.Window win = new Main_forms.Window();
            win.Show();
            Application.Run();
          




        }
    }
}
