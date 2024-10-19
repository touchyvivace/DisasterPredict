using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Regions : BaseAuditableEntity
    {
        public string RegionId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<DisasterType> DisasterType { get; set; }
    }
    public class LatLong
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}