using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Entity.Interfaces;
using N_Base.Entity.Objects;

namespace N_Base.Data.Infra
{
    public interface IContext : IDisposable
    {
        #region Auditoria
        bool Insert(Auditoria auditoria);
        Task<IEnumerable<Auditoria>> GetAuditorias();
        Task<Auditoria> GetAuditoria(long id);
        #endregion
        #region Cargo
        bool Insert(Cargo cargo);
        Task<IEnumerable<Cargo>> GetCargos();
        Task<Cargo> GetCargo(long id);
        #endregion
        #region Conta
        bool Insert(Conta conta);
        Task<IEnumerable<Conta>> GetContas();
        Task<Conta> GetConta(long id);
        #endregion
        #region Endereco
        bool Insert(Endereco endereco);
        Task<IEnumerable<Endereco>> GetEnderecos();
        Task<Endereco> GetEndereco(long id);
        #endregion
    }
}