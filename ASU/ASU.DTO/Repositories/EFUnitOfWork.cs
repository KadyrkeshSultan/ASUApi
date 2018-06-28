using ASU.DAL.Interfaces;
using ASU.DTO.EF;
using ASU.DTO.Interfaces;
using ASU.DTO.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ASU.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private AppDbContext db;
        private IDeclarantRepository declarants;
        private IVerificationDeviceRepository verificationDevices;
        private IVerificatorRepository verificators;
        private ITestEquipmentRepository testEquipments;
        private IMeasurementTypeRepository measurementTypes;
        private IMeasureDeviceTypeRepository measureDeviceTypes;
        private IMeasureDeviceRepository measureDevices;
        private IStampTypeRepository stampTypes;

        public EFUnitOfWork(DbContextOptions<AppDbContext> options)
        {
            db = new AppDbContext(options);
        }

        public IStampTypeRepository StampTypes
        {
            get
            {
                if (stampTypes == null)
                    stampTypes = new StampTypeRepository(db);
                return stampTypes;
            }
        }

        public IMeasureDeviceRepository MeasureDevices
        {
            get
            {
                if (measureDevices == null)
                    measureDevices = new MeasureDeviceRepository(db);
                return measureDevices;
            }
        }

        public IMeasureDeviceTypeRepository MeasureDeviceTypes
        {
            get
            {
                if (measureDeviceTypes == null)
                    measureDeviceTypes = new MeasureDeviceTypeRepository(db);
                return measureDeviceTypes;
            }
        }

        public IMeasurementTypeRepository MeasurementTypes
        {
            get
            {
                if (measurementTypes == null)
                    measurementTypes = new MeasurementTypeRepository(db);
                return measurementTypes;
            }
        }

        public ITestEquipmentRepository TestEquipments
        {
            get
            {
                if (testEquipments == null)
                    testEquipments = new TestEquipmentRepository(db);
                return testEquipments;
            }
        }

        public IVerificatorRepository Verificators
        {
            get
            {
                if (verificators == null)
                    verificators = new VerificatorRepository(db);
                return verificators;
            }
        }

        public IDeclarantRepository Declarants
        {
            get
            {
                if (declarants == null)
                    declarants = new DeclarantRepository(db);
                return declarants;
            }
        }

        public IVerificationDeviceRepository VerificationDevices
        {
            get
            {
                if (verificationDevices == null)
                    verificationDevices = new VerificationDeviceRepository(db);
                return verificationDevices;
            }
        }

        public void Save() => db.SaveChanges();

        public async Task SaveAsync() => await db.SaveChangesAsync();

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();// TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~EFUnitOfWork() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
