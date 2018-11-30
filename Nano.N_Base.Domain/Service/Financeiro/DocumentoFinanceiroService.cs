using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Domain.Interface.Service.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Financeiro
{
    internal class DocumentoFinanceiroService : BaseService<DocumentoFinanceiro>, IDocumentoFinanceiroService
    {
        private readonly IDocumentoFinanceiroRepository _repository;

        public DocumentoFinanceiroService(IDocumentoFinanceiroRepository repository, IBaseValidation<DocumentoFinanceiro> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(DocumentoFinanceiro documentoFinanceiro)
        {
            // Executar verificacoes especificas
            return base.Save(documentoFinanceiro);
        }
    }
}
