using Nano.N_Base.Data.Infra;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Model.Entity;
using System.Data.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Data.Infra
{
    internal class AparelhoContext : BaseEmpresaContext<Aparelho>, IAparelhoContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aparelho>()
                        .HasMany(a => a.Imagens)
                        .WithMany(i => i.Aparelhos)
                        .Map(m => 
                            {
                                m.ToTable("IMAGENS_APARELHOS");
                                m.MapLeftKey("Aparelho_Id");
                                m.MapRightKey("Imagem_Id");
                            });

            base.OnModelCreating(modelBuilder);
        }

        public override bool Save(Aparelho aparelho)
        {
            if (aparelho.Localizacao != null)
                Set(typeof(Localizacao)).Attach(aparelho.Localizacao);

            if (aparelho.Imagens != null && aparelho.Imagens.Count > 0)
                aparelho.Imagens.ToList().ForEach(i => Set(typeof(Imagem)).Attach(i));

            return base.Save(aparelho);
        }
    }
}
