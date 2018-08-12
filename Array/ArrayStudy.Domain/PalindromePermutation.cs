namespace ArrayStudy.Domain
{
    public class PalindromePermutation
    {
        public bool IsPalindrome(string str)
        {
            if(str.Length > 0 )
            {
                bool IsEvenDigital = str.Length % 2 == 0 ? true : false;
                int[] table = BuildDictionary(str);
                return CheckOneMaxOdd(table);
            }
            return true;
        }

        private int GetCharNumber(char c)
        {
            int a = (int)'a';
            int z = (int)'z';
            int val = (int)c;

            if( a <= val && val <= z){
                return val - a;
            }
            return -1;
        }

        private int[] BuildDictionary(string str)
        {
            int[] table = new int[(int)'z' - (int)'a' + 1];
            char[] originalStr = str.ToCharArray();

            for (int i = 0; i < originalStr.Length; i ++)
            {
                int x = GetCharNumber(originalStr[i]);
                if(x > -1){
                    table[x]++;
                }
            }

            return table;
        }

        private bool CheckOneMaxOdd(int[] table)
        {
            int count = 0;
            for (int i = 0; i < table.Length; i ++)
            {
                if(table[i] % 2 == 1)
                {
                    if(count >= 1){
                        return false;
                    }
                    count += 1;
                }
            }
            return true;
        }
    }
}