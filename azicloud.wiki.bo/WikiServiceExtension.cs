using azicloud.wiki.bo.Category;
using azicloud.wiki.bo.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azicloud.wiki.bo
{
    public static class WikiServiceExtension
    {
        public static IServiceCollection AddWikiService(this IServiceCollection services, string conStr)
        {
            services.AddDbContext<DataContext.AppContext>(options =>
                     options.UseSqlServer(conStr));
            services.AddScoped<IDapperService>(sp => new DapperService(conStr));
            services.AddScoped<Iwiki_category, wiki_category>();
            return services;
        }
    }
}
