using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Domain.Models.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario, long>
    {
        Task<Usuario> Obter(string email);
    }
}