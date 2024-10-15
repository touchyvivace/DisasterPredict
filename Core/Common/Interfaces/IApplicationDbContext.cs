using System.Data;
using DisasterPredict.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DisasterPredict.Core.Common.Interfaces;

public interface IApplicationDbContext
{
         DbSet<DisasterPredictInfo> DisasterPredicts {get;}
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

   
}
