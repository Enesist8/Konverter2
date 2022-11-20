using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace konverter
{
    internal class converter
    {
        public string txt;
        public string json;
        public string xml;
        public string input;
        public string path;
        private string notexists = "Вы указали неверный файл или формат";
        void ReadTxt()
        {
            if (File.Exists(path))
            {
                txt = File.ReadAllText(path);
            }
            else
            {
                Console.WriteLine(notexists);
            }
        }
        void ReadJson()
        {
            if (File.Exists(path))
            {
                List<List> result = JsonConvert.DeserializeObject<List<List>>(path);
            }
            else
            {
                Console.WriteLine(notexists);
            }
        }
        void ReadXml()
        {
            if (File.Exists(path))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Path));
                using (FileStream fs = new FileStream(path, FileMode.Open)) ;
                {
                    path = (Path)xml.Deserialize(gg);
                }

            }
            else
            {
                Console.WriteLine(notexists);
            }
        }


    }
}