using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Interfaces
{
    public interface IContextGym : IContext
    {
        #region Avaliacao
        bool Insert(Avaliacao avaliacao);
        Task<IEnumerable<Avaliacao>> GetAvaliacoes();
        Task<Avaliacao> GetAvaliacao(long id);
        #endregion
        #region Cliente
        bool Insert(Cliente cliente);
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetCliente(long id);
        #endregion
        #region Contrato
        bool Insert(Contrato contrato);
        Task<IEnumerable<Contrato>> GetContratos();
        Task<Contrato> GetContrato(long id);
        #endregion
        #region Convenio
        bool Insert(Convenio convenio);
        Task<IEnumerable<Convenio>> GetConvenios();
        Task<Convenio> GetConvenio(long id);
        #endregion
        #region EquipamentoAparelho
        bool Insert(EquipamentoAparelho equipApar);
        Task<IEnumerable<EquipamentoAparelho>> GetEquipamentosAparelhos();
        Task<EquipamentoAparelho> GetEquipamentoAparelho(long id);
        #endregion
        #region Exercicio
        bool Insert(Exercicio exercicio);
        Task<IEnumerable<Exercicio>> GetExercicios();
        Task<Exercicio> GetExercicio(long id);
        #endregion
        #region FichaAvaliacaoCliente
        bool Insert(FichaAvaliacaoCliente fichaAva);
        Task<IEnumerable<FichaAvaliacaoCliente>> GetFichasAvaliacoesClientes();
        Task<FichaAvaliacaoCliente> GetFichaAvaliacaoCliente(long id);
        #endregion
        #region Modalidade
        bool Insert(Modalidade fichaAva);
        Task<IEnumerable<Modalidade>> GetModalidades();
        Task<Modalidade> GetModalidade(long id);
        #endregion
        #region PeriodoModalidade
        bool Insert(PeriodoModalidade preiodo);
        Task<IEnumerable<PeriodoModalidade>> GetPeriodos();
        Task<PeriodoModalidade> GetPeriodo(long id);
        #endregion
        #region Treino
        bool Insert(Treino treino);
        Task<IEnumerable<Treino>> GetTreinos();
        Task<Treino> GetTreino(long id);
        #endregion
    }
}