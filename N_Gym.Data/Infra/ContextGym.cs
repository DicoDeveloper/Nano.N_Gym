using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using N_Gym.Entity.Objects;
using N_Base.Data.Infra;
using Microsoft.Extensions.Configuration;

namespace N_Gym.Data.Infra
{
    public class ContextGym : ContextBase
    {
        #region Propriedades
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<EquipamentoAparelho> EquipamentosAparelhos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<FichaAvaliacaoCliente> FichasAvaliacoesClientes { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<PeriodoModalidade> PeriodosModalidades { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        #endregion

        public ContextGym(DbContextOptions<ContextGym> options) : base(null)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}