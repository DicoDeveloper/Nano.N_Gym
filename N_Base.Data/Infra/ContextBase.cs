using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using N_Base.Data.Interfaces;
using N_Base.Entity.Objects;

namespace N_Base.Data.Infra
{
    public class ContextBase : DbContext, IContext
    {
        #region Propriedades        
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<PermissaoUsuario> PermicoesUsuarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnderecoPessoa>()
                .HasKey(ep => new { ep.EnderecoId, ep.PessoaId });
        }

        #region Metodos Auditoria
        public bool Insert(Auditoria auditoria)
        {
            Auditorias.Add(auditoria);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Auditoria>> GetAuditorias() => await Auditorias.ToListAsync();
        public async Task<Auditoria> GetAuditoria(long id) => await Auditorias.FindAsync(id);
        #endregion
        #region Metodos Cargo
        public bool Insert(Cargo cargo)
        {
            Cargos.Add(cargo);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Cargo>> GetCargos() => await Cargos.ToListAsync();
        public async Task<Cargo> GetCargo(long id) => await Cargos.FindAsync(id);
        #endregion
        #region Metodos Conta
        public bool Insert(Conta conta)
        {
            Contas.Add(conta);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Conta>> GetContas() => await Contas.ToListAsync();
        public async Task<Conta> GetConta(long id) => await Contas.FindAsync(id);
        #endregion
        #region Metodos Endereco
        public bool Insert(Endereco endereco)
        {
            Enderecos.Add(endereco);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Endereco>> GetEnderecos() => await Enderecos.ToListAsync();
        public async Task<Endereco> GetEndereco(long id) => await Enderecos.FindAsync(id);
        #endregion
        #region Metodos Funcionario
        public bool Insert(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Funcionario>> GetFuncionarios() => await Funcionarios.ToListAsync();
        public async Task<Funcionario> GetFuncionario(long id) => await Funcionarios.FindAsync(id);
        #endregion
        #region Metodos Loja
        public bool Insert(Loja loja)
        {
            Lojas.Add(loja);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Loja>> GetLojas() => await Lojas.ToListAsync();
        public async Task<Loja> GetLoja(long id) => await Lojas.FindAsync(id);
        #endregion
        #region Metodos Pagamento
        public bool Insert(Pagamento pagamento)
        {
            Pagamentos.Add(pagamento);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Pagamento>> GetPagamentos() => await Pagamentos.ToListAsync();
        public async Task<Pagamento> GetPagamento(long id) => await Pagamentos.FindAsync(id);
        #endregion
        #region Metodos PermissaoUsuario
        public bool Insert(PermissaoUsuario permissao)
        {
            PermicoesUsuarios.Add(permissao);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<PermissaoUsuario>> GetPermissoes() => await PermicoesUsuarios.ToListAsync();
        public async Task<PermissaoUsuario> GetPermissao(long id) => await PermicoesUsuarios.FindAsync(id);
        #endregion
        #region Metodos Pessoa
        public bool Insert(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Pessoa>> GetPessoas() => await Pessoas.ToListAsync();
        public async Task<Pessoa> GetPessoa(long id) => await Pessoas.FindAsync(id);
        #endregion
        #region Metodos SystemConfig
        public bool Insert(SystemConfig sys)
        {
            SystemConfigs.Add(sys);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<SystemConfig>> GetSystemConfigs() => await SystemConfigs.ToListAsync();
        public async Task<SystemConfig> GetSystemConfig(long id) => await SystemConfigs.FindAsync(id);
        #endregion
        #region Metodos Usuario
        public bool Insert(Usuario user)
        {
            Usuarios.Add(user);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Usuario>> GetUsuarios() => await Usuarios.ToListAsync();
        public async Task<Usuario> GetUsuario(long id) => await Usuarios.FindAsync(id);
        #endregion
    }
}