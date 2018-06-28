using ASU.DAL.Repositories;
using ASU.DTO.Documents;
using ASU.DTO.EF;
using ASU.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASU.DTO.Repositories
{
    public class StampTypeRepository : Repository<StampType>, IStampTypeRepository
    {
        public StampTypeRepository(AppDbContext dbContext)
            :base(dbContext)
        {

        }
        public IEnumerable<StampType> GetAll()
        {
            return db.StampTypes;
        }
    }
}
