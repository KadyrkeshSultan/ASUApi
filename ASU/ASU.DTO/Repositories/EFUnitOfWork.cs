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

        public EFUnitOfWork(DbContextOptions<AppDbContext> options)
        {
            db = new AppDbContext(options);
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
        //public IChoiceRepository Choices
        //{
        //    get
        //    {
        //        if (choiceRepository == null)
        //            choiceRepository = new ChoiceRepository(db);
        //        return choiceRepository;
        //    }
        //}

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
