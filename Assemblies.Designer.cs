namespace PhillIDE
{
    partial class Assemblies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Microsoft.Csharp",
            "System",
            "System.Activities",
            "System.Activities.Core.Presentation",
            "System.Activities.DurableInstancing",
            "System.Activities.Presentation",
            "System.AddIn",
            "System.AddIn.Contract",
            "System.ComponentModel.Composition",
            "System.ComponentModel.Composition.Registration",
            "System.ComponentModel.DataAnnotations",
            "System.Configuration",
            "System.Configuration.Install",
            "System.Core",
            "System.Data",
            "System.Data.DataSetExtensions",
            "System.Data.Entity",
            "System.Data.Entity.Design",
            "System.Data.Linq",
            "System.Data.OracleClient",
            "System.Data.Services",
            "System.Data.Services.Client",
            "System.Data.Services.Design",
            "System.Data.SqlXml",
            "System.Deployment",
            "System.Design",
            "System.DirectoryServices",
            "System.DirectoryServices.AccountManagement",
            "System.DirectoryServices.Protocols",
            "System.Drawing",
            "System.Drawing.Design",
            "System.EnterpriseServices",
            "System.IdentityModel",
            "System.IdentityModel.Selectors",
            "System.IdentityModel.Services",
            "System.IO.Compression",
            "System.IO.Compression.FileSystem",
            "System.IO.Log",
            "System.Management",
            "System.Management.Instrumentation",
            "System.Messaging",
            "System.Net",
            "System.Net.Http",
            "System.Net.Http.WebRequest",
            "System.Numerics",
            "System.Printing",
            "System.Reflection.Context",
            "System.Runtime.Caching",
            "System.Runtime.DurableInstancing",
            "System.Runtime.Remoting",
            "System.Runtime.Serialization",
            "System.Runtime.Serialization.Formatters.Soap",
            "System.Security",
            "System.ServiceModel",
            "System.ServiceModel.Activation",
            "System.ServiceModel.Activities",
            "System.ServiceModel.Channels",
            "System.ServiceModel.Discovery",
            "System.ServiceModel.Routing",
            "System.ServiceModel.Web",
            "System.ServiceProcess",
            "System.Speech",
            "System.Transaction",
            "System.Web",
            "System.Web.abstractions",
            "System.Web.ApplicationServices",
            "System.Web.DataVisualization",
            "System.Web.DataVisualization.Design",
            "System.Web.DynamicData",
            "System.Web.DynamicData.Design",
            "System.Web.Entity",
            "System.Web.Entity.Design",
            "System.Web.Extensions",
            "System.Web.Extensions.Design",
            "System.Web.Mobile",
            "System.Web.RegularExpressions",
            "System.Web.Routing",
            "System.Web.Services",
            "System.Windows",
            "System.Windows.Controls.Ribbon",
            "System.Windows.Forms",
            "System.Windows.Forms.DataVisualization",
            "System.Windows.Forms.DataVisualization.Design",
            "System.Windows.Forms.Input.Manipulations",
            "System.Windows.Forms.Presentation",
            "System.Workflow.Activites",
            "System.Workflow.ComponentModel",
            "System.Workflow.Runtime",
            "System.WorkflowServices",
            "System.Xaml",
            "System.Xml",
            "System.Xml.Linq",
            "System.Xml.Serialization"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(437, 308);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Assemblies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 333);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Assemblies";
            this.Text = "Assemblies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Assemblies_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}