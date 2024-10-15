using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Persistence;
using Microsoft.AspNetCore.Mvc;
using DisasterPredict.Core.Common.Interfaces;
using DisasterPredict.api.Services;

namespace api
{
    public static class ConfigureServices
    {
         public static IServiceCollection AddAPIServices(this IServiceCollection services)
    {
        services.AddSingleton<ICurrentUserService, CurrentUserService>();

        services.AddHttpContextAccessor();
  


        services.Configure<ApiBehaviorOptions>(options =>
     options.SuppressModelStateInvalidFilter = true);

        return services;
    }
    }
}