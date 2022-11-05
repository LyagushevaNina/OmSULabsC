using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSc.MENUITEM
{
    public class MenuItemCalcFormula : MenuItemCore
    {
        public override string Title { get { return "Formula: x/z + y^2"; } }

        public override void Execute()
        {
            Console.WriteLine("Введите три числа для рассчета формулы: x/z + y^2");

            int x = IOUtils.SafeReadInteger("Введите х: ");
            int y = IOUtils.SafeReadInteger("Введите y: ");
            int z = IOUtils.SafeReadInteger("Введите z: ");

            while(true)
            {
                if (z == 0)
                {
                    Console.WriteLine("Число введено некорректно. Введите другое число");
                    Console.Write("Введите z: ");
                    z = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            double result = (x / z) + Math.Pow(y, 2);
            Console.WriteLine($"{result:N3}");
        }
    }
}
