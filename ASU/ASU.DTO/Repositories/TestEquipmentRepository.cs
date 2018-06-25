using ASU.DAL.Repositories;
using ASU.DTO.EF;
using ASU.DTO.Entities;
using ASU.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Repositories
{
    public class TestEquipmentRepository : Repository<TestEquipment>, ITestEquipmentRepository
    {
        public TestEquipmentRepository(AppDbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
