using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    public class CompressionContext
    {
        private ICompression _compression;

        public CompressionContext(ICompression compression)
        {
            _compression = compression;
        }

        public void SetStrategy(ICompression strategy) 
        {
            _compression = strategy;        
        }

        public void CreateArchive(string archiveName)
        {
            _compression.CompressFolder(archiveName);
        }
    }
}
