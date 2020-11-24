using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cursova
{
    public class Serializetion
    {
        public T Deserialize<T>() where T : class
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream stream = File.Open("Test.xml", FileMode.Open))
            {
                return (T)xmlSerializer.Deserialize(stream);
            }
        }
        public void Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer formatter = new XmlSerializer(ObjectToSerialize.GetType());
            if (!File.Exists("Test.xml"))
                File.Create("Test.xml").Dispose();
            using (FileStream fs = new FileStream("Test.xml", FileMode.Truncate))
            {
                formatter.Serialize(fs, ObjectToSerialize);
            }
        }

    }
}
