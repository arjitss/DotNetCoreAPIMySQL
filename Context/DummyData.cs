using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SamplWebApp.Model;

namespace SamplWebApp.Context
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DaysContext>();
                context.Database.EnsureCreated();
                if (context.Days != null && context.Days.Any())
                    return;
                var Days = GetDays().ToArray();
                context.Days.AddRange(Days);
                context.SaveChanges();
            }

        }
        public static List<Days>GetDays()
        {
            List<Days> days = new List<Days>
            {
                new Days{ Id = 1, DayName = "Sunday"},
                new Days{ Id = 2, DayName = "Monday"},
                new Days{ Id = 3, DayName = "Tuesday"},
                new Days{ Id = 4, DayName = "Wednesday"},
                new Days{ Id = 5, DayName = "Thursday"},
                new Days{ Id = 6, DayName = "Friday"},
                new Days{ Id = 7, DayName = "Saturday"},

            };

            return days;
        }
    }
}
