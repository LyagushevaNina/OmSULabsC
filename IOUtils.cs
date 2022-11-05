using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LABSc
{
    public static class IOUtils
    {
        public static int SafeReadInteger(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue))
                {
                    return iValue;
                }
                Console.WriteLine("ERROR: Incorrect format. Enter integer value...");

            }
        }
        public static DateTime SafeReadDate( string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                DateTime date;
                if(DateTime.TryParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
                {
                    return date;
                }
                Console.WriteLine("ERROR: Incorrect format. Enter correct date time...");
            }
        }

        public static bool compare(string str, string str_2)
        {
            if (str==str_2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string RemoveSpaces(string str)
        {
            str = str.ToLower();
            str = Regex.Replace(str, @"\s+", " ");
            str = str.Trim(' ');
            Console.WriteLine(str);
            return str;
        }

        public static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }

        public static bool EmailAddress(string str)
        {
            string mail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            Match mat = Regex.Match(str, mail, RegexOptions.IgnoreCase);
            if (mat.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PhoneNumber(string str)
        {
            string PhoneNumber = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
            Match mat = Regex.Match(str, PhoneNumber, RegexOptions.IgnoreCase);
            if (mat.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IP(string str)
        {
            string IP = @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            Match mat = Regex.Match(str, IP, RegexOptions.IgnoreCase);
            if (mat.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
