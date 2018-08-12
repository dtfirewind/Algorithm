namespace ArrayStudy.Domain
{
    public class IsUnique
    {
        public bool IsUniqueStr(string str)
        {
            bool[] char_set = new bool[128];
            for(int i = 0; i < str.Length; i++)
            {
                int index = str[i];
                if(char_set[index])
                {
                    return false;
                }
                char_set[index] = true;
            }
            return true;
        }
    } 
}