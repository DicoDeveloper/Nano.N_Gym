using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using N_Base.Entity.Objects;

namespace N_Base.Data.Infra
{
    public class ContextBase : DbContext, IContext
    {
        #region Propriedades        
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<CentroCusto> CentroCustos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<PermissaoUsuario> PermicoesUsuarios { get; set; }
        public DbSet<Pessoa> Pessoas {get;set;}
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tabelas
            modelBuilder.Entity<Auditoria>().ToTable("AUDITORIAS");
            modelBuilder.Entity<Cargo>().ToTable("CARGOS");
            modelBuilder.Entity<CentroCusto>().ToTable("CENTRO_CUSTOS");
            modelBuilder.Entity<Cliente>().ToTable("CLIENTES");
            modelBuilder.Entity<Endereco>().ToTable("ENDERECOS");
            modelBuilder.Entity<Funcionario>().ToTable("FUNCIONARIOS");
            modelBuilder.Entity<Pagamento>().ToTable("PAGAMENTOS");
            modelBuilder.Entity<PermissaoUsuario>().ToTable("PERMISSOES_USUARIOS", "dbo");
            modelBuilder.Entity<Pessoa>().ToTable("PESSOAS");
            modelBuilder.Entity<SystemConfig>().ToTable("SYSTEM_CONFIGS", "dbo");
            modelBuilder.Entity<Usuario>().ToTable("USUARIOS", "dbo");
            #endregion
        }
    }
}