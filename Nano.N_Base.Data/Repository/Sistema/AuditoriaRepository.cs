﻿using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class AuditoriaRepository : BaseRepository<Auditoria>, IAuditoriaRepository
    {
        private readonly IAuditoriaContext _context;

        public AuditoriaRepository(IAuditoriaContext context) : base(context)
        {
            _context = context;
        }
    }
}
