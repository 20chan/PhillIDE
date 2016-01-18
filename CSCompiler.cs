using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace PhillIDE
{
    public class CSCompiler
    {
        List<Code> Codes;
        List<string> ReferencedAssemblies = new List<string>();
        string OuterDirectory;

        bool hasError = false;
        string Errors;

        public CSCompiler(List<string> directories, List<string> assemblies)
        {
            foreach(string direct in directories)
            {
                Codes.Add(new Code(direct));
            }
            this.ReferencedAssemblies = assemblies;
        }

        public bool Compile()
        {
            CodeDomProvider codeDom = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters parameters = new CompilerParameters();
            foreach (string s in ReferencedAssemblies)
                parameters.ReferencedAssemblies.Add(s + ".dll");


            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = OuterDirectory;

            string[] codes = new string[Codes.Count];
            
            CompilerResults results = codeDom.CompileAssemblyFromSource(parameters, codes);

            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                }

                hasError = true;
                this.Errors = sb.ToString();
                return false;
            }

            return true;
        }

        public string GetError()
        {
            if (hasError)
                return Errors;
            else
                return "에러가 없습니다.";
        }
    }
}
