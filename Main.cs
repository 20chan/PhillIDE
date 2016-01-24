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
        CSCompiler compiler;
        Assemblies assemblyForm = new Assemblies();

        public Main()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
        }

        private void AddFile(string dir)
        {
            Code c = new Code(dir);
            AddCode(c);
        }

        private void AddCode(Code c)
        {
            ListViewItem item = new ListViewItem(c.FileName());
            item.SubItems.Add(c.Directory);
            this.lvCodes.Items.Add(item);
            TabPage t = new TabPage();
            CodeEditor ce = new CodeEditor(c.Directory);
            ce.Dock = DockStyle.Fill;
            ce.FormBorderStyle = FormBorderStyle.None;
            ce.TopLevel = false;
            ce.Parent = t;
            t.Text = ce.Text;
            tcCodes.TabPages.Add(t);
            ce.Show();
        }

        private void tcCodes_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    AddFile(file);
                }
            }
        }

        private void tcCodes_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }

        private void lvCodes_DoubleClick(object sender, EventArgs e)
        {
            TabPage t = new TabPage();
            CodeEditor ce = new CodeEditor(lvCodes.SelectedItems[0].SubItems[1].Text);
            ce.Dock = DockStyle.Fill;
            ce.FormBorderStyle = FormBorderStyle.None;
            ce.TopLevel = false;
            ce.Parent = t;
            t.Text = ce.Text;
            tcCodes.TabPages.Add(t);
            ce.Show();
        }

        private void 빌드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> dirs = new List<string>();
            foreach(ListViewItem item in lvCodes.Items)
            {
                dirs.Add(item.SubItems[1].Text);
            }

            this.compiler = new CSCompiler(dirs, assemblyForm.ChosenAssemblies);
            if(!compiler.Compile("E:\\OUT.EXE"))
            {
                MessageBox.Show("에러가 있습니다!");
                tbErrors.Clear();
                tbErrors.Text = compiler.GetError();
            }
        }

        private void 어셈블리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assemblyForm.Show();
        }
    }
}
