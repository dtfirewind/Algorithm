using System.Linq;

namespace ArrayStudy.Domain
{
    public class Urlify
    {
        public string UrlifyString(string str)
        {
            if (str != "")
            {
                char[] originalStr = str.ToCharArray();
                int spaceCount = originalStr.Where(x=>string.Equals(x,' ')).Count();
                char[] content = new char[str.Length + spaceCount * 2];
                int index = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if(string.Equals(str[i], ' ')){
                        content[index] = '%';
                        content[index+1] = '2';
                        content[index+2] = '0';
                        index += 3;
                    }else{
                        content[index] = str[i];
                        index++;
                    }
                }
                return string.Concat(content);
            }

            return "";
        }
    }
}
