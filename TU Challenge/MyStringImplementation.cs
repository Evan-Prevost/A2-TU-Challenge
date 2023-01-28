using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            string skipped = "";
            for(int i = 0;i<input.Length;i++)
            {
                if (i % 2 == 0)
                {
                    result+= input[i];
                }
                else
                {
                    skipped+= input[i];
                }
            }
            return result+skipped;
            throw new NotImplementedException();
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null) { return true; }
            foreach (char c in input)
            {
                if (c != ' ') { return false; }
            }
            return true;
            throw new NotImplementedException();
        }

        public static string MixString(string a, string b)
        {
            string result = "";
            if (!(IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b)))
            {
                int min = Math.Min(a.Length, b.Length);
                for (int i = 0; i < min; i++)
                {
                    result += a[i];
                    result += b[i];
                }
                if (a.Length > min)
                {
                    result += a.Substring(min);
                }
                else if (b.Length > min)
                {
                    result += b.Substring(min);
                }
                return result;
            }
            
            throw new ArgumentException();
        }

        public static string Reverse(string a)
        {
            string result = "";
            foreach(char c in a)
            {
                result = c + result;
            }
            return result;
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            foreach (char c in a)
            {
                if ((c>='A' && c <= 'Z') || (c>='Â' && c<='Í'))
                {
                    result += (char)((int)c+32);
                }
                else
                {
                    result += c;
                }
            }
            return result;
            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            string result = "";
            int half = input.Length / 2;
            for (int i = 0; i < input.Length/2; i++)
            {
                result += input[i];
                try
                {
                    result += input[i + half];
                }
                catch { }
            }
            return result;
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {
            string result = "";
            var voyelles = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
            a = ToLowerCase(a);
            foreach (char c in a)
            {
                if (voyelles.Contains(c) && !result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
            throw new NotImplementedException();
        }
    }
}
