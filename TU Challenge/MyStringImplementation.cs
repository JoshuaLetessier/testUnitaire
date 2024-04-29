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
            throw new NotImplementedException();
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input.Length == 0)
                return true;
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (input[i] != ' ')
                        return false;
                }
                return true;
            }
        }

        public static string MixString(string a, string b)
        {
            string result = "";
            if (a == null || a.Length == 0)
                return b;
            if (b == null || b.Length == 0)
                return a;
            if(a.Length < b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (i == a.Length)
                        return result + b.Substring(i).ToString();
                    else if (i == b.Length)
                        return result + a.Substring(i).ToString();
                    else
                        result = result + a[i].ToString() + b[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == a.Length)
                        return result + b.Substring(i).ToString();
                    else if (i == b.Length)
                        return result + a.Substring(i).ToString();
                    else
                        result = result + a[i].ToString() + b[i].ToString();
                }
            }
           
            return result;

        }

        public static string Reverse(string a)
        {
            throw new NotImplementedException();
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            
            for(int i = 0; i < a.Length; i++)
            {
                switch(a[i])
                {
                    case 'É':
                        result = result + 'é';
                        break;
                    case 'À':
                        result = result + 'à';
                        break;
                    case 'È':
                        result = result + 'è';
                        break;
                }
                if (a[i]  >= 'A' && a[i]<= 'Z' && result.Length != a.Length)
                    result = result + (char)(a[i] + 32);
                else if(result.Length != a.Length)
                    result = result + a[i];
            }
            return result;
            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {
            a = ToLowerCase(a);
            for (int i = 0;i < a.Length;i++)
            {
               // if (a[i]. || a[i] = 'e')
            }
            throw new NotImplementedException();
        }
    }
}
