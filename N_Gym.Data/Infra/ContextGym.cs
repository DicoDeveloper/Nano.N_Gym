using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using N_Gym.Entity.Objects;
using N_Base.Data.Infra;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using N_Gym.Data.Interfaces;

namespace N_Gym.Data.Infra
{
    public class ContextGym : ContextBase, IContextGym
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

        public ContextGym(DbContextOptions<ContextGym> options, DbContextOptions<ContextBase> options2) : base(options2)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        #region Metodos Avaliacao
        public bool Insert(Avaliacao avaliacao)
        {
            Avaliacoes.Add(avaliacao);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Avaliacao>> GetAvaliacoes() => await Avaliacoes.ToListAsync();
        public async Task<Avaliacao> GetAvaliacao(long id) => await Avaliacoes.FindAsync(id);
        #endregion
        #region Metodos Cliente
        public bool Insert(Cliente cliente)
        {
            Clientes.Add(cliente);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Cliente>> GetClientes() => await Clientes.ToListAsync();
        public async Task<Cliente> GetCliente(long id) => await Clientes.FindAsync(id);
        #endregion
        #region Metodos Contrato
        public bool Insert(Contrato contrato)
        {
            Contratos.Add(contrato);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Contrato>> GetContratos() => await Contratos.ToListAsync();
        public async Task<Contrato> GetContrato(long id) => await Contratos.FindAsync(id);
        #endregion
        #region Metodos Convenio
        public bool Insert(Convenio convenio)
        {
            Convenios.Add(convenio);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Convenio>> GetConvenios() => await Convenios.ToListAsync();
        public async Task<Convenio> GetConvenio(long id) => await Convenios.FindAsync(id);
        #endregion
        #region Metodos EquipamentoAparelho
        public bool Insert(EquipamentoAparelho equipApar)
        {
            EquipamentosAparelhos.Add(equipApar);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<EquipamentoAparelho>> GetEquipamentosAparelhos() => await EquipamentosAparelhos.ToListAsync();
        public async Task<EquipamentoAparelho> GetEquipamentoAparelho(long id) => await EquipamentosAparelhos.FindAsync(id);
        #endregion
        #region Metodos Exericico
        public bool Insert(Exercicio exercicio)
        {
            Exercicios.Add(exercicio);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Exercicio>> GetExercicios() => await Exercicios.ToListAsync();
        public async Task<Exercicio> GetExercicio(long id) => await Exercicios.FindAsync(id);
        #endregion
        #region Metodos FichaAvaliacaoCliente
        public bool Insert(FichaAvaliacaoCliente fichaAva)
        {
            FichasAvaliacoesClientes.Add(fichaAva);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<FichaAvaliacaoCliente>> GetFichasAvaliacoesClientes() => await FichasAvaliacoesClientes.ToListAsync();
        public async Task<FichaAvaliacaoCliente> GetFichaAvaliacaoCliente(long id) => await FichasAvaliacoesClientes.FindAsync(id);
        #endregion
        #region Metodos Modalidade
        public bool Insert(Modalidade modalidade)
        {
            Modalidades.Add(modalidade);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Modalidade>> GetModalidades() => await Modalidades.ToListAsync();
        public async Task<Modalidade> GetModalidade(long id) => await Modalidades.FindAsync(id);
        #endregion
        #region Metodos PeriodoModalidade
        public bool Insert(PeriodoModalidade periodo)
        {
            PeriodosModalidades.Add(periodo);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<PeriodoModalidade>> GetPeriodos() => await PeriodosModalidades.ToListAsync();
        public async Task<PeriodoModalidade> GetPeriodo(long id) => await PeriodosModalidades.FindAsync(id);
        #endregion
        #region Metodos Treino
        public bool Insert(Treino treino)
        {
            Treinos.Add(treino);
            SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Treino>> GetTreinos() => await Treinos.ToListAsync();
        public async Task<Treino> GetTreino(long id) => await Treinos.FindAsync(id);
        #endregion
    }
}