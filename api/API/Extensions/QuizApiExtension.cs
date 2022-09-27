using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class QuizApiExtension
    {
        public static IServiceCollection AddQuizApiExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options => {
                options.UseSqlServer(config.GetConnectionString("QuizConnection"), b => b.MigrationsAssembly("API"));
            });
 
            return services;
        } 
    }
}