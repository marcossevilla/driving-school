using System;
using Gtk;
using escuela_manejo.Data;
namespace escuela_manejo.Business
{
    public class BScourseOperating
    {   


        public bool BSsaveCourseOperating(CourseOperating courseOperating)
        {
            MessageDialog ms = null;
            bool save = false;
            try
            {
                bool exist = false;
                DTinstanceCourse DTcourOp = new DTinstanceCourse();
                exist = DTcourOp.ExistUser(courseOperating);
                if (exist)
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "El Usuario ya existe!!!");
                    ms.Run();
                    ms.Destroy();
                    return save;
                }
                else
                {
                    save = DTcourOp.SaveCourseOperating(courseOperating);
                    if (save)
                    {
                        //Console.WriteLine("NG: El Usuario se guardo exitosamente!!!");
                        return save;
                    }
                    else
                    {
                        //onsole.WriteLine("NG: Error al guardar el Usuario, Verificar el metodo.");
                        return save;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("NG: ERROR=" + e.Message);
                Console.WriteLine("NG: ERROR=" + e.StackTrace);
                throw;
                //return guardado;
            }
        }


        public BScourseOperating()
        {
        }
    }
}
