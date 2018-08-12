namespace ArrayStudy.Domain
{
    public class StringCompression
    {
        public string CompressString(string originalString)
        {
            string compressedStr = "";
            int count = 0;

            for(int i=0;i<originalString.Length;i++)
            {
                count++;
                if(i + 1 >= originalString.Length || originalString[i] != originalString[i+1])
                {
                    compressedStr += "" + originalString[i] + count;
                    count = 0;
                }
            }

            return compressedStr.Length >= originalString.Length ? originalString : compressedStr;
        }
    }
}