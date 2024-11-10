using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings__in_detail_
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
                return text;
             

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                // add words into list
                summaryWords.Add(word);

                // track total characters in word
                totalCharacters += word.Length + 1; // space of each word
                // if total characters greater than maxLength, break loop and stop adding words
                if (totalCharacters > maxLength)
                    break;
            }

            // join the summaryWords into a single string and add ellipsis for the rest of the words
            return String.Join(" ", summaryWords) + "...";
        }
    }
}
