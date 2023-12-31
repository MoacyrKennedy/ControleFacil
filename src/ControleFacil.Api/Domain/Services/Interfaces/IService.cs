using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Domain.Services.Interfaces
{

    /// <summary>
    /// Iinterface generica para criação de serviõs tipo CRUD
    /// </summary>
    /// <typeparam name="RQ">Contrato de request</typeparam>
    /// <typeparam name="RS">Contrato de response</typeparam>
    /// <typeparam name="I">Tipo do Id</typeparam>
    public interface IService<RQ, RS, I> where RQ : class
    {
        Task<IEnumerable<RS>> Obter(I idUsuario);
        Task<RS> Obter(I id, I idUsuario);
        Task<RS> Adicionar(RQ request, I idUsuario);
        Task<RS> Atualizar(I id, RQ request, I idUsuario);
        Task Inativar(I id, I idUsuario);  
    }
}