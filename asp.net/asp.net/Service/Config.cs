using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Service
{
    public  class Config
    {
        public static string ConnectionString { get;set;}
        public static string CompanyName { get; set; }
        public static string CompanyEmail { get; set; }
        public static string CompanyPhone { get; set; }
    }
}
