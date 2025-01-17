using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using DisasterPredict.Core.Common.Interfaces;
using DisasterPredict.Infrastructure.Persistence.Interceptors;
using Domain.Entities;

namespace Infra.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        static ApplicationDbContext() {
     AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
}
        private readonly IMediator _mediator;
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IMediator mediator,
            AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
            : base(options)
        {
            _mediator = mediator;
            _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        }
    public IDbConnection Connection => Database.GetDbConnection();

        public DbSet<Regions> Regions => Set<Regions>();

        public new DatabaseFacade Database => base.Database;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {

        return await base.SaveChangesAsync(cancellationToken);
    }

    }
}