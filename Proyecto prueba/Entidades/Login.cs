using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public string codigousuario { get; set; }

        public string contrasena { get; set; }

        public string rol { get; set; }

        public Login()
        {
        }

        public Login(string codigousuario, string contrasena, string rol)
        {
            this.codigousuario = codigousuario;
            this.contrasena = contrasena;
            this.rol = rol;
        }
    }
}
