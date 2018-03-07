using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using N_Base.Entity.Interfaces;
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
    }
}