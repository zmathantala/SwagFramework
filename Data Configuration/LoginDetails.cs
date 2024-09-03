using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Data_Configuration
{
    // class to map the JSON structure. 
    public class LoginDetails
    {

        public string username { get; set; }
        public string Password { get; set; }

    }
    // a Config class that mirrors the structure of config.json.
    public class Config
    {
        public LoginDetails LoginDetails { get; set; }
    }
}

