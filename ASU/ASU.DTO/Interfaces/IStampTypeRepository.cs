using ASU.DAL.Interfaces;
using ASU.DTO.Documents;
using System.Collections.Generic;

namespace ASU.DTO.Interfaces
{
    public interface IStampTypeRepository : IRepository<StampType>
    {
        IEnumerable<StampType> GetAll();
    }
}
