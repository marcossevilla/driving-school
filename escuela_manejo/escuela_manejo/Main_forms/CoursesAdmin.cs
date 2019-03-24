using System;
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


        protected virtual void OnButtonAddCourseInstanceClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            AddCourseInstance addCourseIns = new AddCourseInstance();
            addCourseIns.Show();


        }




    }
}
