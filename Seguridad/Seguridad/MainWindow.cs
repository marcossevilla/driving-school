using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void onSalirActionActivated(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void onControlDeUsuarios(object sender, EventArgs e)
    {
        Seguridad.FrmUsuarios frmUsuarios= new Seguridad.FrmUsuarios();

        frmUsuarios.Show();


    }
}
