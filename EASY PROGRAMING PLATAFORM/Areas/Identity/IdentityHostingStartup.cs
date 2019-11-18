using System;
using EASY_PROGRAMING_PLATAFORM.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EASY_PROGRAMING_PLATAFORM.Areas.Identity.IdentityHostingStartup))]
namespace EASY_PROGRAMING_PLATAFORM.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityCursosDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityCursosDBContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<IdentityCursosDBContext>();
            });
        }
    }
}