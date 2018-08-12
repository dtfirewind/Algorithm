namespace ArrayStudy.Domain
{
    public class OneAway
    {
        public bool IsOneEditAway(string str1, string str2)
        {
            if(str1.Length == 0 && str2.Length == 0)
                return true;
                
            if(str1.Length == str2.Length){
                return IsOneReplacement(str1,str2);
            }else if(str1.Length - str2.Length == 1){
                return IsOneInsertion(str2, str1);
            }else if(str1.Length - str2.Length == -1){
                return IsOneInsertion(str1, str2);
            }
            return false;
        }

        private bool IsOneReplacement(string str1, string str2)
        {
            bool differenceFound = false;
            for(int i=0; i<str1.Length;i++)
            {
                if(str1[i] != str2[i])
                {
                    if(differenceFound){
                        return false;
                    }
                    differenceFound = true;
                }
            }
            return differenceFound;
        }

        private bool IsOneInsertion(string str1, string str2)
        {
            int index1 = 0, index2 = 0;
            while(index1 < str1.Length && index2 < str2.Length)
            {
                if(str1[index1] != str2[index2]){
                    if(index1 != index2){
                        return false;
                    }
                    index2++;
                }else{
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}