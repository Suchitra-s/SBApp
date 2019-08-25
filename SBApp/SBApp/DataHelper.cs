using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBApp
{
    public static class DataHelper
    {
        public static List<Word> words = new List<Word>();

        static DataHelper()
        {
            words = ((Words)XMLHelper.DeserializeFromXmlFile<Words>("WordList.xml")).words.ToList();
        }

        public static List<Word> GetWords(int count)
        {
            List<Word> result = new List<Word>();
            for (int i = count; i < count + 10; i++)
            {
                result.Add(words[i]);
            }
            return result;
        }

        public static int GetWordsCount()
        {
            return words.Count;
        }
    }
}
