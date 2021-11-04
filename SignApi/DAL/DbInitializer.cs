using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SignApi.Entities;

namespace SignApi.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SignContext>();
                context.Database.EnsureCreated();

                if (context.Signs.Any())
                {
                    return;   // DB has been seeded
                }
                var signs = new Sign[]
                {
                        new Sign{Id=Guid.NewGuid(), SignName="S001", Location="Bolton"},
                        new Sign{Id=Guid.NewGuid(), SignName="S002", Location="Sale"},
                        new Sign{Id=Guid.NewGuid(), SignName="S003", Location="Cheadle"},
                        new Sign{Id=Guid.NewGuid(), SignName="S004", Location="Stockport"},
                        new Sign{Id=Guid.NewGuid(), SignName="S005", Location="Atherton"},
                        new Sign{Id=Guid.NewGuid(), SignName="S006", Location="Altrincham"},
                        new Sign{Id=Guid.NewGuid(), SignName="S007", Location="Rochdale"},
                };
                context.Signs.AddRange(signs);
                context.SaveChanges();
            }
        }

        public static void InitializeDB(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SignContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
