
using DisasterPredict.Core.Common.Interfaces;

namespace DisasterPredict.Infra.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
