using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ARAPlus.PersistenceSample
{
    public class Person
    {
        public Person()
        {

        }
        public Person(decimal initialSalary)
        {
            Salary = initialSalary;
        }
        [XmlAttribute("fname")]
        public string FirstName { get; set; }

        [XmlElement(ElementName ="Nachname")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person> Children { get; set; }
        protected decimal Salary { get; set; }
    }
}
