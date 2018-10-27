using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace c_
{
    class Program
    {
        // entry point to application and stuff to be fixed
        static void Main(string[] args)
        {
            List<String> strLst = new List<string>() { "apple", "banana", "orange" };
            XDocument doc = new XDocument(
                new XElement("root",
                    strLst.Select(w=> new XElement("str", w))
                )
            );
        }
    }

    public class Activities
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
