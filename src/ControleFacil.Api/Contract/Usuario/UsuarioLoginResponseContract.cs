using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Contract.Usuario
{
    public class UsuarioLoginResponseContract
    {
        public long Id { get; set; }

        public string email { get; set; } = string.Empty;
        
        public string token { get; set; } = string.Empty;
    }
}