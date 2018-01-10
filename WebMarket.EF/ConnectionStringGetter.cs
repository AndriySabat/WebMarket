using System;
using System.Collections.Generic;
using System.Text;

namespace WebMarket.EF
{
    public class ConnectionStringGetter:IConnectionStringGetter
    {
        public static string ConnectionString { get; set; }
    }
}
