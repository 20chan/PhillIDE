using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillIDE
{
    public class Code
    {
        public string Directory { get; set; }
        public string InnerCode { get; set; }

        public Code(string directory)
        {
            this.Directory = directory;
            GetInnerCode();
        }

        public void GetInnerCode()
        {
            this.InnerCode = System.IO.File.ReadAllText(Directory);
        }

        public static string[] GetInnerCodes(List<Code> codes)
        {
            string[] cs = new string[codes.Count];
            for(int i = 0; i < codes.Count; i++)
            {
                cs[i] = codes[i].InnerCode;
            }

            return cs;
        }
    }
}
