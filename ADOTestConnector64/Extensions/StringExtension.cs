using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTestConnector64.Extensions
{
    public static class StringExtension
    {
        public static string FirstCharToUpper(this string str)
        {
            var wordArray = str.Split(' ');
            for (var i = 0; i < wordArray.Length; i++) 
            {
                var word = "";
                for (var j = 0; j < wordArray[i].Length; j++)
                {
                    if (j==0)
                    {
                        word += char.ToUpper(wordArray[i][j]);
                    }
                    else
                    {
                        word += wordArray[i][j];
                    }
                }
                wordArray[i] = word;
            }

            return string.Join(" ", wordArray);
        }
    }
}
