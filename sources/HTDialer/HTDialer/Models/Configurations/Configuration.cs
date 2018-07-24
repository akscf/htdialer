using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

/**
 * 
 * @author AlexandrinK <aks@cforge.org>
 */
namespace HTDialer.Models.Configurations
{
    [XmlRootAttribute("Configuration", Namespace="", IsNullable=false)]
    public class Configuration
    {
        public int Version { get; set; }
        public string Url { get; set; }
        public string Hotkey { get; set; }
        public string Regex { get; set; }

        public Configuration ()
        {
            Version = 0;
        }

        public Configuration(int version)
        {
            Version = version;
        }

        public override string ToString()
        {
            return "version: " + Version + "url: " + Url + ", hotkey: " + Hotkey + ", regex: " + Regex;
        }
    }
}
