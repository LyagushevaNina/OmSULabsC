﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSc.MENUITEM
{
    public abstract class MenuItemCore
    {
        public abstract string Title { get; }

        public abstract void Execute();
    }
}

