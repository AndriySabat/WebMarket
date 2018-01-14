using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.EF.Context;
using Microsoft.EntityFrameworkCore;
using WebMarket.EF;

namespace WebMarket.DbConfig
{
    public class ConfigContext : WebMarketDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Program.Main();

            optionsBuilder.UseSqlServer(ConnectionStringGetter.ConnectionString);
        }
    }
}
