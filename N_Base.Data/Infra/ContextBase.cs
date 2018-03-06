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
            
        }
    }
}