using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleXmlSerializable
{
    class Program
    {
            static void Main(string[] args)
            {
                Person person = new Person { FirstName = "Nathan", LastName = "Krasney", Age = 12 };
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                string xml;

                using (StringWriter stringWriter = new StringWriter())
                {
                    serializer.Serialize(stringWriter, person);
                    xml = stringWriter.ToString();
                }

                Console.WriteLine(xml);

                using (StringReader stringReader = new StringReader(xml))
                {
                    Person p = (Person)serializer.Deserialize(stringReader);
                    Console.WriteLine("deserialized person age : {0}", p.Age);
                }

                Console.ReadKey();
            }
    }
}
