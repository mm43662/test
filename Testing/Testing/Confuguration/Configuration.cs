using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Confuguration
    {
    internal static class Configuration
        {
        public static readonly string Dates = Path.Combine(
           Directory.GetCurrentDirectory(),
           "DateHibru.xml"
       );
        }
    }
