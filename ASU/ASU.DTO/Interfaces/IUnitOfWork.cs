using System;
using System.Threading.Tasks;
using ASU.DAL.Repositories;
using ASU.DTO.Interfaces;

namespace ASU.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDeclarantRepository Declarants { get; }
        IVerificationDeviceRepository VerificationDevices { get; }
        IVerificatorRepository Verificators { get; }
        ITestEquipmentRepository TestEquipments { get; }
        IMeasurementTypeRepository MeasurementTypes { get; }

        void Save();
        Task SaveAsync();
    }
}
