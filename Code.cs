using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillIDE
{
    public class Code
    {
        private string directory;
        public string Directory { get { return directory; } }
        private string innerCode;

        public Code(string directory)
        {
            this.directory = directory;
            GetInnerCode();
        }

        public void GetInnerCode()
        {
            this.innerCode = System.IO.File.ReadAllText(directory);
        }

        public string FileName()
        {
            return System.IO.Path.GetFileName(directory);
        }

        public static string[] GetInnerCodes(List<Code> codes)
        {
            string[] cs = new string[codes.Count];
            for(int i = 0; i < codes.Count; i++)
            {
                cs[i] = codes[i].innerCode;
            }

            return cs;
        }
    }
}
