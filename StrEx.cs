using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABSc.MENUITEM;

namespace LABSc.MENUITEM
{
    class StrEx
    {
        public static void CompareEx(string a, string b)
        {
            if(IOUtils.compare(a,b) != true)
            {
                throw new Exception("Строки не совпадают посимвольно");
            }
        }
        public static void EmailEx(string a)
        {
            if (IOUtils.EmailAddress(a) != true)
            {
                throw new Exception(a + " строка не является email'ом.");
            }
        }
        public static void PhoneNumberEx(string a)
        {
            if (IOUtils.PhoneNumber(a) != true)
            {
                throw new Exception(a + " строка не является номером телефона.");
            }
        }
        public static void IPEx(string a)
        {
            if (IOUtils.IP(a) != true)
            {
                throw new Exception(a + " строка не является IP адресом.");
            }
        }

    }
}
