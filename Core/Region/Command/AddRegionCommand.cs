using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisasterPredict.Core.Common.Interfaces;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Core.Region.Command
{
    public record AddRegionCommand : IRequest<Regions>
    {
        public string RegionId { get; set; }
        public LatLong LocationCoordinates { get; set; }
        public List<DisasterType> DisasterType { get; set; }
    }
    public class AddRegionCommandHandler : IRequestHandler<AddRegionCommand, Regions>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddRegionCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Regions> Handle(AddRegionCommand request, CancellationToken cancellationToken)
        {
            var region = new Regions
            {
                RegionId = request.RegionId,
                Latitude = request.LocationCoordinates.Latitude,
                Longitude = request.LocationCoordinates.Longitude,
                DisasterType = request.DisasterType
            };

            _applicationDbContext.Regions.Add(region);
           await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return region;
        }
    }
}