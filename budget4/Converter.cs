using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget4
{
    class Converter
    {
        public static void MySerialize0<T>(T nouns)
        {
            
            string money_json = JsonConvert.SerializeObject(nouns);
            File.WriteAllText("D:\\Soft\\Dekstop\\Money.json", money_json);

        }
        public static void MySerialize1<T>(T nouns)
        {

            string types_json = JsonConvert.SerializeObject(nouns);
            File.WriteAllText("D:\\Soft\\Dekstop\\Types.json", types_json);

        }

        public static T MyDeserialize<T>()
        {
            string json_money = File.ReadAllText("D:\\Soft\\Dekstop\\Money.json");
            T money = JsonConvert.DeserializeObject<T>(json_money);
            return money;

        }

        public static T MyDeserialize2<T>()
        {
            string json_type = File.ReadAllText("D:\\Soft\\Dekstop\\Types.json");
            T types = JsonConvert.DeserializeObject<T>(json_type);
            return types;
        }
    }
}