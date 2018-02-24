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
        public DbSet<ClienteGym> ClientesGym { get; set; }
        public DbSet<EquipamentoAparelho> EquipamentosAparelhos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<ExercicioTreino> ExerciciosTreinos { get; set; }
        public DbSet<FichaAvaliacaoCliente> FichasAvaliacoesClientes { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<ModalidadeCliente> ModalidadesClientes { get; set; }
        public DbSet<PagamentoModalidadeCliente> PagamentosModalidadesClientes { get; set; }
        public DbSet<PeriodoModalidade> PeriodosModalidades { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        #endregion

        public ContextGym(DbContextOptions<ContextGym> options) : base(null)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tabelas
            modelBuilder.Entity<Avaliacao>().ToTable("AVALIACOES");
            modelBuilder.Entity<ClienteGym>().ToTable("CLIENTES_GYM");
            modelBuilder.Entity<EquipamentoAparelho>().ToTable("EQUIPAMENTOS_APARELHOS");
            modelBuilder.Entity<Exercicio>().ToTable("EXERCICIOS");
            modelBuilder.Entity<ExercicioTreino>().ToTable("EXERCICIOS_TREINOS");
            modelBuilder.Entity<FichaAvaliacaoCliente>().ToTable("FICHAS_AVALIACOES_CLIENTES");
            modelBuilder.Entity<Modalidade>().ToTable("MODALIDADES");
            modelBuilder.Entity<ModalidadeCliente>().ToTable("MODALIDADES_CLIENTES");
            modelBuilder.Entity<PagamentoModalidadeCliente>().ToTable("PAGAMENTOS_MODALIDADES_CLIENTES");
            modelBuilder.Entity<PeriodoModalidade>().ToTable("PERIODOS_MODALIDADES");
            modelBuilder.Entity<Treino>().ToTable("TREINOS");
            #endregion
        }
    }
}