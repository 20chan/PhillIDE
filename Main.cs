using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace PhillIDE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;

            CodeEditor c = new CodeEditor(@"N:\C#\PhillIDE\PhillIDE\Code.cs");
            c.TopLevel = false;
            c.Parent = this.pnCodes;
            c.Show();

            CodeEditor d = new CodeEditor(@"N:\C#\PhillIDE\PhillIDE\CSCompiler.cs");
            d.TopLevel = false;
            d.Parent = this.pnCodes;
            d.Show();

            CodeEditor e = new CodeEditor(@"N:\C#\PhillIDE\PhillIDE\CodeEditor.cs");
            e.TopLevel = false;
            e.Parent = this.pnCodes;
            e.Show();
        }
    }
}
