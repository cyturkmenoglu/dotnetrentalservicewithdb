using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Classes
{
    public static class Connection
    {
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
    }
}
