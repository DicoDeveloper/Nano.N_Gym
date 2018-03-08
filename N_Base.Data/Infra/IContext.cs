using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        #region Funcionario
        bool Insert(Funcionario funcionario);
        Task<IEnumerable<Funcionario>> GetFuncionarios();
        Task<Funcionario> GetFuncionario(long id);
        #endregion
        #region Loja
        bool Insert(Loja loja);
        Task<IEnumerable<Loja>> GetLojas();
        Task<Loja> GetLoja(long id);
        #endregion
        #region Pagamento
        bool Insert(Pagamento pagamento);
        Task<IEnumerable<Pagamento>> GetPagamentos();
        Task<Pagamento> GetPagamento(long id);
        #endregion
        #region PermissaoUsuario
        bool Insert(PermissaoUsuario permissaoUsuario);
        Task<IEnumerable<PermissaoUsuario>> GetPermissoes();
        Task<PermissaoUsuario> GetPermissao(long id);
        #endregion
    }
}