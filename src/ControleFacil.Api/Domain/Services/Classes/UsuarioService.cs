using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Contract.Usuario;
using ControleFacil.Api.Domain.Models.Interfaces;
using ControleFacil.Api.Domain.Services.Interfaces;

namespace ControleFacil.Api.Domain.Services.Classes
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository? _usuarioRepository;


        public UsuarioService(IUsuarioRepository usuarioRepository) {
            _usuarioRepository = usuarioRepository;
        }
        public Task<UsuarioResponseContract> Adicionar(UsuarioRequestContract request, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponseContract> Atualizar(long id, UsuarioRequestContract request, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioLoginResponseContract> Autenticar(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Task Inativar(long id, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioResponseContract>> Obter(long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponseContract> Obter(long id, long idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}