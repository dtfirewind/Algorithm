using System;
using System.Collections.Generic;

namespace DynamicProgramming.Domain
{
    public class Permutations
    {
        public List<string> GetPerms(string str)
        {
            if (str == null) return null;

            List<string> permutations = new List<string>();

            if (str.Length == 0)
            {
                permutations.Add("");
                return permutations;
            }

            char first = str[0];
            string remainder = str.Substring(1);
            List<string> words = GetPerms(remainder);
            foreach (string word in words)
            {
                for(int j = 0; j <= word.Length; j++){
                    string s = InsertChatAt(word, first, j);
                    permutations.Add(s);
                }
            }
            return permutations;
        }

        public string InsertChatAt(string word, char c, int i){
            string start = word.Substring(0,i);
            string end = word.Substring(i);
            return start + end;
        }
    }

}