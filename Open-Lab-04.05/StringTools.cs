using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string result = String.Empty;
            foreach (char a in orig)
            {
                for (int g = 0; g < n; g++)
                {
                    result += a;
                }
            }
            return result;
        }
    }
}
