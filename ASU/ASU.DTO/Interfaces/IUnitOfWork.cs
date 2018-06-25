﻿using System;
using System.Threading.Tasks;
using ASU.DAL.Repositories;
using ASU.DTO.Interfaces;

namespace ASU.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDeclarantRepository Declarants { get; }
        void Save();
        Task SaveAsync();
    }
}