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
            try
            {
                CreateDirectoryIfDoesntExist(filename);

                XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    serializer.Serialize(fs, settings);
                }
            }
            catch (IOException e)
            {
                throw new IOException(string.Format("{0}の保存に失敗しました．", filename), e);
            }
        }

        private static void CreateDirectoryIfDoesntExist(string filename)
        {
            try
            {
                if (Directory.Exists(filename))
                    return;
                else
                    Directory.CreateDirectory(Path.GetDirectoryName(filename));
            }
            catch (IOException)
            {
                throw;
            }
        }

        public static Settings Load(string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    return (Settings)serializer.Deserialize(fs);
                }
            }
            catch (IOException e)
            {
                throw new IOException(string.Format("{0}の読み込みに失敗しました．", filename), e);
            }
        }
    }
}
