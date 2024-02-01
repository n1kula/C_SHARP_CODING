using System;

namespace Common
{
    public static class StringSupport
    {
        public static string AddSpace(string str)
        {
            string result = string.Empty;

            if (!String.IsNullOrEmpty(str))
            {
                foreach (char c in str)
                {
                if (char.IsUpper(c))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                result += c;
                }
                result = result.Trim();
            }
            return result;
        }
    }
}
