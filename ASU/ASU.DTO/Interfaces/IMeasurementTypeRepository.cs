using ASU.DAL.Interfaces;
using ASU.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASU.DTO.Interfaces
{
    public interface IMeasurementTypeRepository : IRepository<MeasurementType>
    {
        IEnumerable<MeasurementType> GetAll();
    }
}
