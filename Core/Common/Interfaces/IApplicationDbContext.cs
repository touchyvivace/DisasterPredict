using System.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DisasterPredict.Core.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Regions> Regions { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);


}
