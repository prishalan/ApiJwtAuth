using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiJwtAuth.Data;
using ApiJwtAuth.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiJwtAuth.Bootstrap
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<AuthApplicationContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ApiJwtAuthDefaultConnection"));
            });

            services.AddIdentityCore<User>(options => { });
            new IdentityBuilder(typeof(User), typeof(IdentityRole), services)
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddSignInManager<SignInManager<User>>()
                .AddEntityFrameworkStores<AuthApplicationContext>();
        }
    }
}
