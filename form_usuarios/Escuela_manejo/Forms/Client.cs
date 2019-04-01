using System;
namespace users.Forms
{
    public partial class ClientF : Gtk.Window
    {
        public ClientF() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
