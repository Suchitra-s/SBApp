using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SBApp
{
    public class Word
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Meaning")]
        public string Meaning { get; set; }
    }

    [XmlRoot("Words")]
    public class Words
    {
        [XmlElement("Word")]
        public List<Word> words { get; set; }
    }
}
