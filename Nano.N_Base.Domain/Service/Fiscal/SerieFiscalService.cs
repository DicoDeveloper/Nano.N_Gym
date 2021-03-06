﻿using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Domain.Interface.Service.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Fiscal
{
    internal class SerieFiscalService : BaseService<SerieFiscal>, ISerieFiscalService
    {
        private readonly ISerieFiscalRepository _repository;

        public SerieFiscalService(ISerieFiscalRepository repository, IBaseValidation<SerieFiscal> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(SerieFiscal serieFiscal)
        {
            // Executar verificacoes especificas
            return base.Save(serieFiscal);
        }
    }
}
