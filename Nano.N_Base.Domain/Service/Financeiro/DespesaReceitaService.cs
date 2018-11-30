using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Domain.Interface.Service.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Financeiro
{
    internal class DespesaReceitaService : BaseService<DespesaReceita>, IDespesaReceitaService
    {
        private readonly IDespesaReceitaRepository _repository;

        public DespesaReceitaService(IDespesaReceitaRepository repository, IBaseValidation<DespesaReceita> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(DespesaReceita despesaReceita)
        {
            // Executar verificacoes especificas
            return base.Save(despesaReceita);
        }
    }
}
