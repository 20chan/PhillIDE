using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhillIDE
{
    public partial class CodeEditor : Form
    {
        public CodeEditor(string codeDirect)
        {
            InitializeComponent();
            this.Text = System.IO.Path.GetFileName(codeDirect);
            this.tbCode.Text = System.IO.File.ReadAllText(codeDirect);
        }
    }
}
