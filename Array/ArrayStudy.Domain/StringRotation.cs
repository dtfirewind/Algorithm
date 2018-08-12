namespace ArrayStudy.Domain
{
    public class StringRotation
    {
        public bool isRotation(string sl, string s2)
        {
            int len = sl.Length;
            /* Check that sl and s2 are equal length and not empty*/
            if (len == s2.Length && len > 0)
            {
                /* Concatenate sl and sl within new buffer */
                string slsl = sl + sl;
                return isSubstring(slsl, s2);
            }
            return false;
        }

        private bool isSubstring(string str1, string str2)
        {
            return true;
        }
    }
}