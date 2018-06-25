using ASU.DAL.Repositories;
using ASU.DTO.Actors;
using ASU.DTO.EF;
using ASU.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Repositories
{
    public class VerificatorRepository : Repository<Verificator>, IVerificatorRepository
    {
        public VerificatorRepository(AppDbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
