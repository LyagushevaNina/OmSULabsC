using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSc.MENUITEM
{
    public class MenuItemStr : MenuItemCore
    {
        public override string Title { get { return "String"; } }
        public override void Execute() 
        {
            Console.WriteLine("Введите две строки: ");
            String str = Console.ReadLine();
            String str_2 = Console.ReadLine();

            try
            {
                StrEx.CompareEx(str, str_2);
                Console.WriteLine("Строки совпадают посимвольно");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            str = IOUtils.RemoveSpaces(str);
            str_2 = IOUtils.RemoveSpaces(str_2);

            try
            {
                StrEx.CompareEx(str, str_2);
                Console.WriteLine("Строки совпадают, если привести к одному регистру, удалить пробелы в начале и в конце и дублировать строки.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            string reverse = IOUtils.ReverseString(str_2);
            try
            {
                StrEx.CompareEx(str, reverse);
                Console.WriteLine("Строка является перевёртышем другой.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                StrEx.EmailEx(str);
                Console.WriteLine(str + " Строка является Email'ом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                StrEx.EmailEx(str_2);
                Console.WriteLine(str_2 + " Строка является Email'ом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StrEx.PhoneNumberEx(str);
                Console.WriteLine(str + " Строка является номером телефона");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                StrEx.PhoneNumberEx(str_2);
                Console.WriteLine(str_2 + " Строка является номером телефона");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StrEx.IPEx(str);
                Console.WriteLine(str + " Строка является IP адресом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                StrEx.IPEx(str_2);
                Console.WriteLine(str_2 + " Строка является IP адресом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
