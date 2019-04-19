using System;
using Gtk;
using Escuela_Manejo1.entidades;
using Escuela_Manejo1.Datos;
namespace Escuela_Manejo1.Otros
{
    public class mgCustomer
    {
        #region metodo
        public bool Mguardarcliente(Customer cus)
        {
            MessageDialog msj = null;
            bool guardado = false; 
            try
            {
                bool existe = false;
                dtCliente cl = new dtCliente();
                existe = cl.existeCliente(cus);
                if(existe)
                {
                    msj = new MessageDialog(null,DialogFlags.Modal,MessageType.Error,ButtonsType.Ok,"El cliente ya existe");
                    msj.Run();
                    msj.Destroy();
                    return guardado;
                 
                }
                else
                {
                    guardado = cl.GuardarCliente(cus);
                    if(guardado)
                    {
                        Console.WriteLine("NG: El cliente se guardo");
                        return guardado;
                    }
                    else {
                        Console.WriteLine("NG: Error al guardar cliente");
                      
                        return guardado;

                    }

                }


            }
            catch(Exception e)
            {
                Console.WriteLine("NG: Error 404= "+e.Message);
                Console.WriteLine("NG: Error= "+e.StackTrace);
                throw;

            }

        }
        #endregion


        public mgCustomer()
        {
        }
    }
}
