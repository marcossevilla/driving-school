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

    protected void OnGestionClienteActionActivated(object sender, EventArgs e)
    {
        Escuela_Manejo1.Frm_Clientes frmu = new Escuela_Manejo1.Frm_Clientes();
        frmu.Show();
    }

    protected void OnSalirActionActivated(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnGestionInstructorActionActivated(object sender, EventArgs e)
    {
        Escuela_Manejo1.Frm_instructor frins = new Escuela_Manejo1.Frm_instructor();
        frins.Show();
    }
}
