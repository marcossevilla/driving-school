using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel) => Build();

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void onClickBtnPayment(object sender, EventArgs e)
    {
        drive.Payment payment = new drive.Payment();
        payment.Show();
    }
}
