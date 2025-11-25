using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec3LabExam_STANDIFER
{
    public class Decoder
    {
        private Dictionary<char, char> plainToCipher;
        private Dictionary<char, char> cipherToPlain;

        public Decoder()
        {
            plainToCipher = new Dictionary<char, char>()
            {
                {'A','R'}, {'B','S'}, {'C','N'}, {'D','E'}, {'E','P'},
                {'F','H'}, {'G','C'}, {'H','A'}, {'I','T'}, {'J','I'},
                {'K','M'}, {'L','G'}, {'M','L'}, {'N','X'}, {'O','W'},
                {'P','V'}, {'Q','F'}, {'R','U'}, {'S','J'}, {'T','Z'},
                {'U','K'}, {'V','O'}, {'W','B'}, {'X','Y'}, {'Y','D'},
                {'Z','Q'}
            };

            cipherToPlain = new Dictionary<char, char>();
            foreach (var kvp in plainToCipher)
                cipherToPlain[kvp.Value] = kvp.Key;
        }

        // Conversion method
        public string ConvertText(string input, bool toCipher)
        {
            Dictionary<char, char> map = toCipher ? plainToCipher : cipherToPlain;
            char[] result = input.ToUpper().ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (map.ContainsKey(result[i]))
                    result[i] = map[result[i]];
                // leave spaces, punctuation, numbers unchanged
            }
            return new string(result);
        }
    }
}
