using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSinkr.Workflow
{
    public class SyncFile
    {
        public string Filename { get; }
        public string Path { get; }

        public byte[] File { get; }

        public SyncFile(string filename, string path, byte[] file)
        {
            Filename = filename;
            Path = path;
            File = file;
        }
    }
}
