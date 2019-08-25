using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SBApp
{
    public static class Common
    {
        public static async void InitializeWords()
        {
            await Task.Factory.StartNew(delegate
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(SpellItRight)).Assembly;
                Stream stream = assembly.GetManifestResourceStream("SBApp.WordList.xml");
                XDocument doc = XDocument.Load(stream);
                IEnumerable<Word> words = from s in doc.Descendants("Word")
                                          select new Word
                                          {
                                              Name = s.Attribute("Name").Value,
                                              Meaning = s.Attribute("Meaning").Value
                                          };
                WordsToLearn = words.ToList();
            });
        }

        public static List<Word> WordsToLearn { get; set;}
    }
}
