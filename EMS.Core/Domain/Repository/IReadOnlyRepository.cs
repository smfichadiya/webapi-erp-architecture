﻿using System;
using System.Linq;
using EMS.Core.Domain.Entities;
using EMS.Core.Domain.Specification;

namespace EMS.Core.Domain.Repository
{
    public interface IReadOnlyRepository<TEntity> : IDisposable where TEntity : IAggregateRoot, new()
    {
        TEntity FindBy(ISpecification<TEntity> spec);

        IQueryable<TEntity> FilterBy(ISpecification<TEntity> spec);

        IQueryable<TEntity> GetAll();

        TEntity GetById(object id);
    }
}