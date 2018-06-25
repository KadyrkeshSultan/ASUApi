using ASU.DAL.Repositories;
using ASU.DTO.EF;
using ASU.DTO.Entities;
using ASU.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Repositories
{
    public class MeasureDeviceTypeRepository : Repository<MeasureDeviceType>, IMeasureDeviceTypeRepository
    {
        public MeasureDeviceTypeRepository(AppDbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
