using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApi.Models
{
    public class Settings
    {
        public string Secret { get; set; }
        public string DataBaseConnection { get; set; }
        public double TokenExpirationHours { get; set; }
    }
}
