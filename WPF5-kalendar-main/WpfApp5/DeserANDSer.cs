using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    internal class DeserANDSer
    {
        
        static string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\Info\DataaboutselectedElemets.json";

        public static void Serialization<T>(List<T> serializableList)
        {
            string json = JsonConvert.SerializeObject(serializableList);
            if (!File.Exists(path))
                Directory.CreateDirectory($@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\Info");
            File.WriteAllText(path, json);
        }

        public static List<T> Deserialization<T>()
        {
            List<T> serializedList = new List<T>();
            if (!File.Exists(path))
                return serializedList;
            string json = File.ReadAllText(path);
            serializedList = JsonConvert.DeserializeObject<List<T>>(json);
            return serializedList;
        }
    }
}
