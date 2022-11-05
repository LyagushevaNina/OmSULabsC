using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABSc.MENUITEM;

namespace LABSc
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Menu.ClearItems();
            Menu.AddItem(new MenuItemExit());
            Menu.AddItem(new MenuItemHelloWorld());
            Menu.AddItem(new MenuItemCalcFormula());
            Menu.AddItem(new MenuItemRecursion());
            Menu.AddItem(new MenuItemStr());
            while (true)
            {
                Menu.ShowMenu();
                Menu.Execute();
            }
        }
    }
}
