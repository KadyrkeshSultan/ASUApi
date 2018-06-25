using System.Collections.Generic;
using System.Threading.Tasks;
using ASU.DAL.Repositories;
using ASU.DTO.EF;
using ASU.DTO.Entities;
using ASU.DTO.Interfaces;

namespace ASU.DTO.Repositories
{
    public class MeasurementTypeRepository : Repository<MeasurementType>, IMeasurementTypeRepository
    {
        public MeasurementTypeRepository(AppDbContext dbContext)
            :base(dbContext)
        {

        }

        public IEnumerable<MeasurementType> GetAll()
        {
            return db.MeasurementTypes;
        }
    }
}
