﻿using BLL.Repository.Interfaces;
using DAL.Repository;

namespace API.Configuration
{
    public static class DependecyInjection
    {
        public static void RegisterDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}