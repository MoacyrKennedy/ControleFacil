using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AutoMapper;
using ControleFacil.Api.Contract.Usuario;
using ControleFacil.Api.Domain.Models;
using ControleFacil.Api.Domain.Models.Interfaces;
using ControleFacil.Api.Domain.Services.Interfaces;
using ControleFacil.Api.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleFacil.Api.Domain.Services.Classes
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;


        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper) {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        public async Task<UsuarioResponseContract> Adicionar(UsuarioRequestContract entidade, long idUsuario)
        {
            var usuario = _mapper.Map<Usuario>(entidade); 

            usuario.Senha=  GerarHAshSenha(usuario.Senha);
            
            usuario = await _usuarioRepository.Adicionar(usuario);

            return _mapper.Map<UsuarioResponseContract>(usuario);
    
    
         }

        private string GerarHAshSenha(string senha)
        {
            string hashSenha;

            using (SHA256 shA256 = SHA256.Create())
            {
                byte[] bytesSenha = System.Text.Encoding.UTF8.GetBytes(senha);
                byte[] bytesHashSenha = shA256.ComputeHash(bytesSenha);
                hashSenha = BitConverter.ToString(bytesHashSenha).ToLower();
            }

            return hashSenha;
        }

        public Task<UsuarioResponseContract> Atualizar(long id, UsuarioRequestContract entidade, long idUsuario)
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