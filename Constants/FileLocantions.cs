﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw.Constants
{
    internal static class FileLocantions
    {
        public static string ProjectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
    }
}
