using Nano.N_Base.Data.Infra;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Model.Entity;
using System.Data.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Data.Infra
{
    internal class ImagemContext : BaseContext<Imagem>, IImagemContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imagem>()
                        .HasMany(a => a.Aparelhos)
                        .WithMany(i => i.Imagens)
                        .Map(m =>
                        {
                            m.ToTable("IMAGENS_APARELHOS");
                            m.MapLeftKey("Imagem_Id"); 
                            m.MapRightKey("Aparelho_Id");
                        });

            base.OnModelCreating(modelBuilder);
        }

        public override bool Save(Imagem imagem)
        {
            if (imagem.Aparelhos != null && imagem.Aparelhos.Count > 0)
                imagem.Aparelhos.ToList().ForEach(a => Set(typeof(Aparelho)).Attach(a));

            return base.Save(imagem);
        }
    }
}
