using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string archiveName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + archiveName
                 + ".rar' file is created");
        }
    }
}
