using ASU.DAL.Repositories;
using ASU.DTO.Actors;
using ASU.DTO.EF;
using ASU.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Repositories
{
    public class DeclarantRepository : Repository<Declarant>, IDeclarantRepository
    {
        public DeclarantRepository(AppDbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
