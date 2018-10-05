using System;
using System.Collections.Generic;

namespace DynamicProgramming.Domain
{
    public class Paren
    {
        public List<string> GenerateParens(int remaining)
        {
            List<string> set = new List<string>();

            if(remaining == 0){
                set.Add("");
            }else{
                List<string> prev = GenerateParens(remaining - 1);
                foreach (string str in prev)
                {
                    for(int i=0; i < str.Length; i++)
                    {
                        if(str[i] == '('){
                            string s = InsertInside(str, i);
                            if(!set.Contains(s)){
                                set.Add(s);
                            }
                        }
                    }
                    set.Add("()" + str);
                }
            }
            return set;
        }

        public string InsertInside(string str, int index)
        {
            string left = str.Substring(0, index + 1);
            string right = str.Substring(index + 1);
            return left + "()" + right;
        }
    }
}