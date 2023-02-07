using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamYankeeBLL.SQL;

namespace TeamYankeeBLL.Extension
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddRostersServices(this IServiceCollection services)
        {
            services.AddTransient<IDataParser, DataParser>();
            services.AddTransient<IRosterRepository, RosterRepository>();
            services.AddTransient<IFormationsRepository, FormationRepository>();
            services.AddTransient<IOptionsRepository, OptionsRepository>();
            services.AddTransient<ISpecificationRepository, SpecificationRepository>();
            services.AddTransient<IUnitsRepository, UnitRepository>();

            return services;
        }
    }
}
