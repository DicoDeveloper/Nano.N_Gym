using Nano.N_Base.Data.Infra;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Model.Entity;
using System.Data.Entity;

namespace Nano.N_Gym.App.Data.Infra
{
    internal class AparelhoContext : BaseEmpresaContext<Aparelho>, IAparelhoContext
    {
        public virtual DbSet<Localizacao> Localizacoes { get; set; }

        public override bool Save(Aparelho aparelho)
        {
            aparelho.Localizacao = aparelho.Localizacao != null ? Localizacoes.Find(aparelho.Localizacao.Id) : null;

            return base.Save(aparelho);
        }
    }
}
