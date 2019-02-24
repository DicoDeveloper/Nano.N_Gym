using Nano.N_Base.Data.Infra;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Model.Entity;
using System.Data.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Data.Infra
{
    internal class LocalizacaoContext : BaseEmpresaContext<Localizacao>, ILocalizacaoContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Localizacao>()
                        .HasMany(l => l.Aparelhos)
                        .WithOptional(a => a.Localizacao)
                        .HasForeignKey(s => s.IdLocalizacao); ;

            base.OnModelCreating(modelBuilder);
        }

        public override bool Save(Localizacao localizacao)
        {
            if (localizacao.Aparelhos.Count > 0)
                localizacao.Aparelhos.ToList().ForEach(a => Set(typeof(Aparelho)).Attach(a));

            return base.Save(localizacao);
        }
    }
}
