﻿using System;
using escuela_manejo.Data;

namespace escuela_manejo.Security_forms
{
    public partial class SecurityAdmin : Gtk.Window
    {
        public SecurityAdmin() :
                base(Gtk.WindowType.Toplevel)
        {
            var DTsecurityAdmin = new DTsecurityAdmin();
            this.Build();
        }

        protected virtual void OnButtonAddUserClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            SecurityAddUser adduser = new SecurityAddUser();
            adduser.Show();


        }

    }
}
