using System;
using System.Text;

namespace BitManipulation.Domain
{
    public class BinaryToString
    {
        public string ConverToString(double num)
        {
            if(num >= 1 || num <= 0)
            {
                return "ERROR";
            }

            StringBuilder str = new StringBuilder();
            str.Append(".");

            while(num > 0)
            {
                if(str.Length >= 32){
                    return "ERROR";
                }

                double r = num * 2;
                if(r >= 1){
                    str.Append("1");
                    num = r - 1.0;
                }else{
                    str.Append("0");
                    num = r;
                }
            }
            return str.ToString();
        }
    }
}