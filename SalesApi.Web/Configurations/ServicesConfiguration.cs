﻿using Microsoft.Extensions.DependencyInjection;
using SalesApi.Services.Retail;

namespace SalesApi.Web.Configurations
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            #region Settings

            #endregion

            #region Overall

            #endregion

            #region Retail

            services.AddScoped(typeof(IRetailService<>), typeof(RetailService<>));
            services.AddScoped<IRetailDayService, RetailDayService>();

            #endregion
        }
    }
}