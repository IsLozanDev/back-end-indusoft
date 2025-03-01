﻿using Microsoft.EntityFrameworkCore;
using MINEDU.IEST.Estudiante.Entity.Audit;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace MINEDU.IEST.Estudiante.Repository.Audit
{
    public class AuditLogRepository : GenericRepository<AuditLog>, IAuditLogRepository
    {
        //public AuditLogRepository(AuditDbContext _context) : base(_context)
        //{
        //}
        public AuditLogRepository(DbContext context) : base(context)
        {
        }
    }
}
