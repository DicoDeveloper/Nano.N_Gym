using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Domain.Interface.Service.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Domain.Service.Fiscal
{
    internal class DocumentoFiscalService : BaseService<DocumentoFiscal>, IDocumentoFiscalService
    {
        private readonly IDocumentoFiscalRepository _repository;

        public DocumentoFiscalService(IDocumentoFiscalRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(DocumentoFiscal documentoFiscal)
        {
            // Executar verificacoes especificas
            return base.Save(documentoFiscal);
        }
    }
}
