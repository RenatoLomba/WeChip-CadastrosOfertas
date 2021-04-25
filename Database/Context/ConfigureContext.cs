using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WeChip_CadastrosOfertas.Database.Context
{
    public class ConfigureContext<T> where T : DbContext
    {
        public static void Configure(IServiceCollection serviceCollection, string connection)
        {
            
            serviceCollection.AddDbContext<MyContext>(options =>
                options.UseSqlite(connection)
            );
        }
    }
}
