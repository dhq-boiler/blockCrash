using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ScrollCrash
{
    [Serializable]
    public class Settings
    {
        public int UseCameraNumber { get; set; }

        public static void Save(string filename, Settings settings)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                serializer.Serialize(fs, settings);
            }
        }

        public static Settings Load(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                return (Settings)serializer.Deserialize(fs);
            }
        }
    }
}
