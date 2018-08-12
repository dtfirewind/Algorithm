using System;

namespace ArrayStudy.Domain
{
    public class Permutation
    {
        public bool IsPermutation(string str1, string str2)
        {
            if(str1.Length != str2.Length)
                return false;

            if(str1.Length > 0)
            {
                str1 = SortArray(str1);
                str2 = SortArray(str2);
                if(str1 == str2)
                {
                    return true;
                }else{
                    return false;
                }
            }
            return true;
        }

        private string SortArray(string str)
        {
            char[] content = str.ToCharArray();
            Array.Sort(content);
            return String.Concat(content);
        }
    } 
}