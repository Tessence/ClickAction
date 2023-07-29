using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClickAction
{
    [DataContract]
    public class ActionItemData
    {
        public ActionItemData()
        {
        }
        public ActionItemData(string name, string cwd, string command)
        {
            this.cwd = cwd;
            this.command = command;
            this.name = name;
        }

        [DataMember]
        public string cwd { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string command { get; set; }

        [DataMember]
        public List<string> relys { get; set; }

        public static List<ActionItemData> UnMarshalList(string content)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List < ActionItemData >));
            var mStream = new MemoryStream(Encoding.Default.GetBytes(content));
            //var result = (T)serializer.ReadObject(stream);
            List<ActionItemData> result = (List<ActionItemData>)serializer.ReadObject(mStream);
            return result;
        }

        public static string MarshalList(List<ActionItemData> items)
        {
            var setting = new DataContractJsonSerializerSettings();
            setting.UseSimpleDictionaryFormat = true;
            
            var mStream = new MemoryStream();
            using (var writer = JsonReaderWriterFactory.CreateJsonWriter(mStream, Encoding.UTF8, true, true," "))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<ActionItemData>), setting);
                serializer.WriteObject(writer, items);
                writer.Flush();
                mStream.Position = 0;
                var sr = new StreamReader(mStream);
                return sr.ReadToEnd();
            }
        }
    }
}
