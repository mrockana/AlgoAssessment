using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class VowelCount
    {
        public int Count(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Value cannot be null or empty.");
            }

            var count = 0;
            value = value.ToUpperInvariant();
            for (int i = 0; i < value.Length; i++)
            {
                char letter = value[i];
                if (letter == 'A')
                {
                    count++;
                }
                else if (letter == 'E')
                {
                    count++;
                }
                else if (letter == 'I')
                {
                    count++;
                }
                else if (letter == 'O')
                {
                    count++;
                }
                else if (letter == 'U')
                {
                    count++;
                }
            }

            return count;
        }
    }
}