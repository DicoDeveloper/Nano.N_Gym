using N_Base.Data.Infra;
using N_Sale.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace N_Sale.Data.Infra
{
    public class ContextSale : ContextBase, IContextSale
    {
        public ContextSale(DbContextOptions<ContextSale> options, DbContextOptions<ContextBase> options2) : base(options2)
        {
        }
    }
}