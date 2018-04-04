using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLStreamToObject
{
    public class Serializer
    {
        public  T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }        

    }

}
