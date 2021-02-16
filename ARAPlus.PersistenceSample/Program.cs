using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NuJson = System.Text.Json.JsonSerializer;

namespace ARAPlus.PersistenceSample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            string path = @"c:\workshops\people1.xml";
            string pathJson = @"c:\workshops\people1.json";

            using (FileStream jsonLoad = File.Open(pathJson, FileMode.Open))
            {
                // deserialize object graph into a List of Person 
                var loadedPeople = (List<Person>)
                await NuJson.DeserializeAsync(
                  utf8Json: jsonLoad,
                  returnType: typeof(List<Person>));
                foreach (var item in loadedPeople)
                {
                   
                }
            }

            var xs = new XmlSerializer(typeof(List<Person>));
            // create a file to write to
        

            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                // deserialize and cast the object graph into a List of Person 
                var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);
                foreach (var item in loadedPeople)
                {
                    
                }
            }




            var people = new List<Person>
{
  new Person(30000M) { FirstName = "Alice",
    LastName = "Smith",
    DateOfBirth = new DateTime(1974, 3, 14) },
  new Person(40000M) { FirstName = "Bob",
    LastName = "Jones",
    DateOfBirth = new DateTime(1969, 11, 23) },
  new Person(20000M) { FirstName = "Charlie",
    LastName = "Cox",
    DateOfBirth = new DateTime(1984, 5, 4),
    Children = new HashSet<Person>
      { new Person(0M) { FirstName = "Sally",
        LastName = "Cox",
        DateOfBirth = new DateTime(2000, 7, 12) } } }
};

            using (StreamWriter jsonStream = File.CreateText(pathJson))
            {
                // create an object that will format as JSON 
                var jss = new Newtonsoft.Json.JsonSerializer();
                // serialize the object graph into a string 
                jss.Serialize(jsonStream, people);
            }


            // create object that will format a List of Persons as XML 

            using (FileStream stream = File.Create(path))
            {
                // serialize the object graph to the stream 
                xs.Serialize(stream, people);
            }
        }
    }
}
