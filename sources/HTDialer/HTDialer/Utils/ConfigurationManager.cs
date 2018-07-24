using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using HTDialer.Models.Configurations;

/**
 * 
 * @author AlexandrinK <aks@cforge.org>
 */
namespace HTDialer.Utils
{
    class ConfigurationManager
    {
        private const int VERSION = 1;
        private String filename;
        public Configuration configuration;

        public ConfigurationManager()
        {
            this.filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//htdealer.xml";
        }

        public void Load()
        {
            if (!System.IO.File.Exists(filename))
            {
                CreateDefault();
                Save();
            }
            else
            {
                using (TextReader tr = CreateTextReader())
                {
                    XmlSerializer seralizer = new XmlSerializer(typeof(Configuration));
                    configuration = (Configuration)seralizer.Deserialize(tr);
                }
            }
            //
            if (VERSION.CompareTo(configuration.Version) != 0)
            {
                CreateDefault();
                Save();
            }

        }

        public void Save()
        {
            using (TextWriter tw = CreateTextWriter())
            {
                XmlSerializer seralizer = new XmlSerializer(typeof(Configuration));
                seralizer.Serialize(tw, configuration);
            }
        }


        public void Delete()
        {
            if (System.IO.File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }

        }

        public Configuration Configuration()
        {
            return configuration;
        }

        // ================================================================================================================
        private Configuration CreateDefault()
        {
            configuration = new Configuration(VERSION);
            configuration.Url = @"http://127.0.0.1/cgi-bin/cgiServer.exx?number=%number%";
            configuration.Hotkey = @"ctrl+alt+f12";
            configuration.Regex = @"^\d{7,11}$"; // @"^\+??\d{7,11}$";
            //
            return configuration;
        }

        private TextWriter CreateTextWriter()
        {
            TextWriter tw = new StreamWriter(filename);
            return tw;
        }

        private TextReader CreateTextReader()
        {
            TextReader tr = new StreamReader(filename);
            return tr;
        }

    }

}
