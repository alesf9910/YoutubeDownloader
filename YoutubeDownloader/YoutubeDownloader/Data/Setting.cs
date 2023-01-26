using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Data
{
    [Serializable]
    public class Setting
    {
        public Proxy Proxy { get; set; }

        public void Save(string file)
        {
            using(TextWriter writer = new StreamWriter(file))
            {
                writer.Write(JsonConvert.SerializeObject(this));
            }
        }

        public static Setting Load(string file)
        {
            if (File.Exists(file))
            {
                string content;
                using (TextReader reader = new StreamReader(file))
                {
                    content = reader.ReadToEnd();
                }
                return JsonConvert.DeserializeObject<Setting>(content);
            }
            else
            {
                return new Setting();
            }
        }

        public Setting()
        {
            Proxy = new Proxy();
        }
    }
}
