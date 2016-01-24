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
    public partial class Assemblies : Form
    {
        public List<string> ChosenAssemblies = new List<string>();
        public Assemblies()
        {
            InitializeComponent();
        }

        private void Assemblies_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChosenAssemblies = new List<string>();

            for (int i = 0; i < this.checkedListBox1.SelectedItems.Count; i++)
            {
                ChosenAssemblies.Add(checkedListBox1.SelectedItems[i].ToString());
            }
            e.Cancel = true;
            this.Hide();
        }
    }
}
