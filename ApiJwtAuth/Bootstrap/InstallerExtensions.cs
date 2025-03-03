﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJwtAuth.Bootstrap
{
    public static class InstallerExtensions
    {
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
                typeof(Bootstrap.IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract
            ).Select(Activator.CreateInstance).Cast<Bootstrap.IInstaller>().ToList();

            installers.ForEach(installer => installer.InstallServices(configuration, services));
        }
    }
}
