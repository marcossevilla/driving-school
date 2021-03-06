﻿using System;
using escuela_manejo.Data;

namespace escuela_manejo.Main_forms
{
    public partial class CoursesAdmin : Gtk.Window
    {
        public CoursesAdmin() :
                base(Gtk.WindowType.Toplevel)
        {
            var DTcoursesAdmin = new DTcoursesAdmin();
            this.Build();
        }

        protected virtual void OnButtonAddCourseClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            AddCourse addCourse = new AddCourse();
            addCourse.Show();


        }


        protected virtual void OnButtonModifyCourseClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            ModifyCourse modCourse = new ModifyCourse();
            modCourse.Show();


        }


        protected virtual void OnButtonAddCourseInstanceClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            AddCourseInstance addCourseIns = new AddCourseInstance();
            addCourseIns.Show();


        }


        protected virtual void OnButtonAddService(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            AddService addService = new AddService();
            addService.Show();


        }


        protected virtual void OnButtonModifyService(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            ModifyService modifyService = new ModifyService();
            modifyService.Show();


        }




    }
}
