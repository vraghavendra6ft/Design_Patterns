﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    public interface ICompression
    {
        void CompressFolder(string archiveName);
    }
}
