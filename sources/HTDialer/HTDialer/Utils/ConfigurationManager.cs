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
 * Copyright (C) AlexandrinKS
 * https://akscf.me/
 */
namespace HTDialer.Utils
{
    class ConfigurationManager
    {
        private const int VERSION = 5;
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
                CreateDefault(false);
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
                CreateDefault(true);
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
        private Configuration CreateDefault(bool storeOld)
        {
            Configuration old = configuration;
            //
            configuration = new Configuration(VERSION);
            configuration.Url = storeOld && !String.IsNullOrEmpty(old.Url) ?  old.Url : @"http://127.0.0.1/cgi-bin/cgiServer.exx?number=%number%";
            configuration.Hotkey = storeOld && !String.IsNullOrEmpty(old.Hotkey) ? old.Hotkey: @"ctrl+alt+f12";
            configuration.Regex = storeOld && !String.IsNullOrEmpty(old.Regex) ? old.Regex : @"^\d{7,11}$";
            configuration.CutChars = storeOld && !String.IsNullOrEmpty(old.CutChars) ? old.Regex : @"+-()";
            configuration.Credentials = storeOld && !String.IsNullOrEmpty(old.Credentials) ? old.Credentials : "";
            configuration.ShowInTaskbar = storeOld ? old.ShowInTaskbar : false;
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
