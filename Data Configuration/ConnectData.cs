using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Data_Configuration
{
    public class ConnectData
    {
        //Implement code to read and deserialize the JSON configuration file.
        public static Config LoadConfig()
        {
            // Path to the config.json file
            string configFilePath = "Config.json";

            // Read the file content
            string json = File.ReadAllText(configFilePath);

            // Deserialize JSON to Config object
            return JsonConvert.DeserializeObject<Config>(json);
        }
    }
}
