using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSc.MENUITEM
{
    public class MenuItemRecursion : MenuItemCore
    {
        public override string Title { get { return "Recursion"; } }

        public override void Execute()
        {
             DateTime dateStartMax, dateEndMin;

             DateTime FirstStart = IOUtils.SafeReadDate("Enter first date start:");
             Console.WriteLine("Value is {0}.{1}.{2}", FirstStart.Day, FirstStart.Month, FirstStart.Year);

             DateTime FirstEnd = IOUtils.SafeReadDate("Enter first date end:");
             Console.WriteLine("Value is {0}.{1}.{2}", FirstEnd.Day, FirstEnd.Month, FirstEnd.Year);
            
            if(FirstEnd<FirstStart)
            {
                while(true)
                {
                    Console.WriteLine("Incorrect format. Date end can't be < date start");
                    DateTime End = IOUtils.SafeReadDate("Enter first date end again:");
                    Console.WriteLine("Value is {0}.{1}.{2}", End.Day, End.Month, End.Year);
                    FirstEnd = End;
                    if(FirstEnd>=FirstStart)
                    {
                        break;
                    }
                }
                
            }

            DateTime SecondStart = IOUtils.SafeReadDate("Enter second date start:");
             Console.WriteLine("Value is {0}.{1}.{2}", SecondStart.Day, SecondStart.Month, SecondStart.Year);

             DateTime SecondEnd = IOUtils.SafeReadDate("Enter second date end:");
             Console.WriteLine("Value is {0}.{1}.{2}", SecondEnd.Day, SecondEnd.Month, SecondEnd.Year);

            if (SecondEnd < SecondStart)
            {
                while (true)
                {
                    Console.WriteLine("Incorrect format. Date end can't be < date start");
                    DateTime End = IOUtils.SafeReadDate("Enter second date end again:");
                    Console.WriteLine("Value is {0}.{1}.{2}", End.Day, End.Month, End.Year);
                    SecondEnd = End;
                    if (SecondEnd >= SecondStart)
                    {
                        break;
                    }
                }

            }

            if (FirstStart>SecondStart)
            {
                dateStartMax = FirstStart;
            }
            else
            {
                dateStartMax = SecondStart;
            }
            if (FirstEnd < SecondEnd)
            {
                dateEndMin = FirstEnd;
            }
            else
            {
                dateEndMin = SecondEnd;
            }

            TimeSpan Intersect = dateEndMin.Date - dateStartMax.Date;
            int n = Convert.ToInt32(Intersect.Days) + 1;
           

            if (n > 0)
            {
                Console.WriteLine("Intersection ={0} ", n);
                if (function(n))
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("Intersection = 0");
                Console.WriteLine("No");
            }
            
            
        }
        public static bool function(int a)
        {
            if (a == 2)
            {
                return true;
            }
            else if (a % 2 == 0)
            {
                return function(a / 2);
            }
            else
            {
                return false;
            }
        }
    }
}
