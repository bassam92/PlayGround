using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace COde.DataProvider
{
    public class Reader
    {
        public static void LoadJson()
        {
            string filePath = WebApiConfig.FilePath();
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
    }
}