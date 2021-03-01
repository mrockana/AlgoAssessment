using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */

    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1))
            {
                throw new ArgumentException($"{nameof(word1)} cannot be empty.");
            }

            if (string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException($"{nameof(word2)} cannot be empty.");
            }

            word1 = word1.ToUpperInvariant();
            word2 = word2.ToUpperInvariant();

            var word1Array = RemovePantuationsOrSpace(word1.ToCharArray());
            var word2Array = RemovePantuationsOrSpace(word2.ToCharArray());

            if (word1Array.Length != word2Array.Length)
            {
                return false;
            }

            for (int i = 0; i < word1Array.Length; i++)
            {
                if (!Array.Exists(word2Array, e => e == word1Array[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private char[] RemovePantuationsOrSpace(char[] array)
        {
            var resultList = new List<char>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!char.IsPunctuation(array[i]) && !char.IsWhiteSpace(array[i]))
                {
                    resultList.Add(array[i]);
                }
            }

            return resultList.ToArray();
        }
    }
}