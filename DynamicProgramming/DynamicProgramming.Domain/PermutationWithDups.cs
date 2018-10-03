using System;
using System.Collections.Generic;

namespace DynamicProgramming.Domain
{
    public class PermutationWithDups
    {
        public List<string> PrintPerms(string s)
        {
            List<string> result = new List<string>();
            Dictionary<char, int> map = BuildMap(s);
            PrintPerms(map, "", s.Length, result);
            return result;
        }

        public Dictionary<char, int> BuildMap(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if(map.ContainsKey(c)){
                    map[c]++;
                }else{
                    map.Add(c, 1);
                }
            }

            return map;
        }

        public void PrintPerms(Dictionary<char,int> map, string prefix, int remaining, List<string> result)
        {
            if(remaining == 0){
                result.Add(prefix);
                return;
            }

            foreach (char c in map.Keys)
            {
                int count = map[c];
                if(count> 0){
                    map[c]--;
                    PrintPerms(map, prefix + c, remaining - 1, result);
                    map[c] = count;
                }
            }
        }
    }
}