using System.Collections.Generic;
using System.Text;

namespace CaesarCrypto
{
    public class Cryptography
    {
        private static List<string> letters = new List<string>()
                { "a", "b", "c", "d", "e", "f", "g", "h",
                  "i", "j", "k", "l", "m", "n", "o", "p",
                  "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        /// <summary>
        /// Cryptograph an word or phrase
        /// </summary>
        /// <param name="phrase">Phrase to be cryptographed</param>
        /// <param name="key">Key</param>
        /// <returns>Crypted Word or phrase</returns>
        public string Encrypt(string phrase, int key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in phrase)
            {
                // Search in the dictionary
                var x = letters.BinarySearch(letter.ToString().ToLower());

                if (x < 0) // Charactere not found
                    sb.Append(letter.ToString());
                else
                {
                    if ((x + key) >= 26)
                        x -= 26;

                    if (string.Equals(letter.ToString(), letter.ToString().ToUpper()))
                        sb.Append(letters[x + key].ToUpper());
                    else
                        sb.Append(letters[x + key]);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Decryptograph an word or phrase
        /// </summary>
        /// <param name="phrase"></param>
        /// <param name="key"></param>
        /// <returns>Decrypted Word or phrase</returns>
        public string Decrypt(string phrase, int key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in phrase)
            {
                var x = letters.BinarySearch(letter.ToString().ToLower());

                if (x < 0) // Charactere not found
                    sb.Append(letter.ToString());
                else
                {
                    if ((x - key) < 0)
                        x += 26;

                    if (string.Equals(letter.ToString(), letter.ToString().ToUpper()))
                        sb.Append(letters[x - key].ToUpper());
                    else
                        sb.Append(letters[x - key]);
                }
            }

            return sb.ToString();
        }
    }
}
