using System;
using Gtk;
using escuela_manejo.Data;
namespace escuela_manejo.business
{
    public class BSservice
    {
        public BSservice()
        {
        }

        #region metodos
        public bool BSsaveService(CourseService tservices)
        {
            MessageDialog ms = null;
            bool save = false;
            try
            {
                bool exist = false;
                DTservice Dtservices = new DTservice();
                exist = Dtservices.ExistService(tservices);
                if (exist)
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "El Usuario ya existe!!!");
                    ms.Run();
                    ms.Destroy();
                    return save;
                }
                else
                {
                    save = Dtservices.SaveService(tservices);
                    if (save)
                    {
                        Console.WriteLine("NG: El Usuario se guardo exitosamente!!!");
                        return save;
                    }
                    else
                    {
                        Console.WriteLine("NG: Error al guardar el Usuario, Verificar el metodo.");
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

        public bool BSupdateCourse(Course Tcour)
        {
            return true;


        }

        #endregion

    }
}
