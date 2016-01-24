namespace PhillIDE
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.빌드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.어셈블리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tcCodes = new System.Windows.Forms.TabControl();
            this.lvCodes = new System.Windows.Forms.ListView();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.빌드ToolStripMenuItem,
            this.어셈블리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 빌드ToolStripMenuItem
            // 
            this.빌드ToolStripMenuItem.Name = "빌드ToolStripMenuItem";
            this.빌드ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.빌드ToolStripMenuItem.Text = "빌드";
            this.빌드ToolStripMenuItem.Click += new System.EventHandler(this.빌드ToolStripMenuItem_Click);
            // 
            // 어셈블리ToolStripMenuItem
            // 
            this.어셈블리ToolStripMenuItem.Name = "어셈블리ToolStripMenuItem";
            this.어셈블리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.어셈블리ToolStripMenuItem.Text = "어셈블리";
            this.어셈블리ToolStripMenuItem.Click += new System.EventHandler(this.어셈블리ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 948F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbErrors, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tcCodes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lvCodes, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(942, 442);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tcCodes
            // 
            this.tcCodes.AllowDrop = true;
            this.tcCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCodes.Location = new System.Drawing.Point(203, 3);
            this.tcCodes.Multiline = true;
            this.tcCodes.Name = "tcCodes";
            this.tcCodes.SelectedIndex = 0;
            this.tcCodes.Size = new System.Drawing.Size(736, 436);
            this.tcCodes.TabIndex = 4;
            this.tcCodes.DragDrop += new System.Windows.Forms.DragEventHandler(this.tcCodes_DragDrop);
            this.tcCodes.DragEnter += new System.Windows.Forms.DragEventHandler(this.tcCodes_DragEnter);
            // 
            // lvCodes
            // 
            this.lvCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCodes.FullRowSelect = true;
            this.lvCodes.Location = new System.Drawing.Point(3, 3);
            this.lvCodes.Name = "lvCodes";
            this.lvCodes.Size = new System.Drawing.Size(194, 436);
            this.lvCodes.TabIndex = 2;
            this.lvCodes.UseCompatibleStateImageBehavior = false;
            this.lvCodes.View = System.Windows.Forms.View.List;
            // 
            // tbErrors
            // 
            this.tbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbErrors.Location = new System.Drawing.Point(3, 451);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbErrors.Size = new System.Drawing.Size(942, 74);
            this.tbErrors.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "PhillIDE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 빌드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 어셈블리ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView lvCodes;
        private System.Windows.Forms.TextBox tbErrors;
        private System.Windows.Forms.TabControl tcCodes;
    }
}

