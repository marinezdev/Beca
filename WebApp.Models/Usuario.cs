using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string cotizar { get; set; }
        public string message { get; set; }
    }

    public class NuevoUsuario
    {
        public List<Usuario> usuario { get; set; }
    }
}
