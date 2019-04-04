using System;
using escuela_manejo.Data;
namespace escuela_manejo.Main_forms
{
    public partial class AddCourseInstance : Gtk.Window
    {
        public AddCourseInstance() :
                base(Gtk.WindowType.Toplevel)
        {
            CourseOperating ins = new CourseOperating();
             DTinstanceCourse dtins= new DTinstanceCourse();
            this.Build();
        }
    }
}
