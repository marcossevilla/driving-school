using System;
using escuela_manejo.Connection;
namespace escuela_manejo.Data
{
    public class DTsecurityAdmin
    {
        public DTsecurityAdmin()
        {

            var consecurityAd = new Connection.Connection();
            consecurityAd.AbrirCOnexion();


        }
    }
}
