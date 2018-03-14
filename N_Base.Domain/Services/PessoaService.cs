using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        public PessoaService(IRepositoryBase<Pessoa> repository) : base(repository)
        {
        }
    }
}