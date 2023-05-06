using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OtusEducationHomework6
{
    internal class MyFileClass
    {
        public event EventHandler<FileArgs> FileFound;

        public void Run(string path)
        {
            if (Directory.Exists(path))
                {
                foreach (var file in Directory.GetFiles(path))
                {
                    var fileArgs = new FileArgs(file);
                    FileFound.Invoke(this, fileArgs);
                    if (fileArgs.Exit)
                        break;
                }
            }
        }
    }
}
