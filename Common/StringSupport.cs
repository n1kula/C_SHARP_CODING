﻿using System;

namespace Common
{
    public class StringSupport
    {
        public string AddSpace(string str)
        {
            string result = string.Empty;
            if (!String.IsNullOrEmpty(str))
            {
                foreach (char c in str)
                {
                if (char.IsUpper(c))
                    {
                        result += c;
                    }
                }
            }
            return result;
        }
    }
}
