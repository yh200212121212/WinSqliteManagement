namespace WinSqliteManagement
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstdb = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.新建数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.清空表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstStructure = new System.Windows.Forms.ListView();
            this.lstContent = new System.Windows.Forms.ListView();
            this.panel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.splitContainer1);
            this.panel.Location = new System.Drawing.Point(12, 62);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(663, 395);
            this.panel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstdb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(663, 395);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstdb
            // 
            this.lstdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstdb.FormattingEnabled = true;
            this.lstdb.ItemHeight = 12;
            this.lstdb.Location = new System.Drawing.Point(0, 0);
            this.lstdb.Name = "lstdb";
            this.lstdb.Size = new System.Drawing.Size(194, 395);
            this.lstdb.TabIndex = 0;
            this.lstdb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstdb_MouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstTables);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "对象";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstTables
            // 
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 12;
            this.lstTables.Location = new System.Drawing.Point(3, 3);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(451, 363);
            this.lstTables.TabIndex = 0;
            this.lstTables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTables_MouseDoubleClick);
            // 
            // txtDbPath
            // 
            this.txtDbPath.Location = new System.Drawing.Point(12, 26);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.Size = new System.Drawing.Size(421, 21);
            this.txtDbPath.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(600, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pwd：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(480, 26);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(97, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开数据库ToolStripMenuItem,
            this.关闭数据库ToolStripMenuItem,
            this.toolStripSeparator1,
            this.新建数据库ToolStripMenuItem,
            this.数据库属性ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 98);
            // 
            // 打开数据库ToolStripMenuItem
            // 
            this.打开数据库ToolStripMenuItem.Name = "打开数据库ToolStripMenuItem";
            this.打开数据库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开数据库ToolStripMenuItem.Text = "打开数据库";
            // 
            // 关闭数据库ToolStripMenuItem
            // 
            this.关闭数据库ToolStripMenuItem.Name = "关闭数据库ToolStripMenuItem";
            this.关闭数据库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关闭数据库ToolStripMenuItem.Text = "关闭数据库";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // 新建数据库ToolStripMenuItem
            // 
            this.新建数据库ToolStripMenuItem.Name = "新建数据库ToolStripMenuItem";
            this.新建数据库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建数据库ToolStripMenuItem.Text = "新建数据库";
            // 
            // 数据库属性ToolStripMenuItem
            // 
            this.数据库属性ToolStripMenuItem.Name = "数据库属性ToolStripMenuItem";
            this.数据库属性ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据库属性ToolStripMenuItem.Text = "数据库属性";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开表ToolStripMenuItem,
            this.设计表ToolStripMenuItem,
            this.新建表ToolStripMenuItem,
            this.删除表ToolStripMenuItem,
            this.toolStripSeparator2,
            this.清空表ToolStripMenuItem,
            this.toolStripSeparator3,
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(113, 148);
            // 
            // 打开表ToolStripMenuItem
            // 
            this.打开表ToolStripMenuItem.Name = "打开表ToolStripMenuItem";
            this.打开表ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开表ToolStripMenuItem.Text = "打开表";
            // 
            // 设计表ToolStripMenuItem
            // 
            this.设计表ToolStripMenuItem.Name = "设计表ToolStripMenuItem";
            this.设计表ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.设计表ToolStripMenuItem.Text = "设计表";
            // 
            // 新建表ToolStripMenuItem
            // 
            this.新建表ToolStripMenuItem.Name = "新建表ToolStripMenuItem";
            this.新建表ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.新建表ToolStripMenuItem.Text = "新建表";
            // 
            // 删除表ToolStripMenuItem
            // 
            this.删除表ToolStripMenuItem.Name = "删除表ToolStripMenuItem";
            this.删除表ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.删除表ToolStripMenuItem.Text = "删除表";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(109, 6);
            // 
            // 清空表ToolStripMenuItem
            // 
            this.清空表ToolStripMenuItem.Name = "清空表ToolStripMenuItem";
            this.清空表ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.清空表ToolStripMenuItem.Text = "清空表";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(109, 6);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstStructure);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(457, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 结构 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstContent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(457, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " 内容 ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstStructure
            // 
            this.lstStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStructure.Location = new System.Drawing.Point(0, 0);
            this.lstStructure.Name = "lstStructure";
            this.lstStructure.Size = new System.Drawing.Size(457, 369);
            this.lstStructure.TabIndex = 0;
            this.lstStructure.UseCompatibleStateImageBehavior = false;
            this.lstStructure.View = System.Windows.Forms.View.Details;
            // 
            // lstContent
            // 
            this.lstContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstContent.Location = new System.Drawing.Point(0, 0);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(457, 369);
            this.lstContent.TabIndex = 1;
            this.lstContent.UseCompatibleStateImageBehavior = false;
            this.lstContent.View = System.Windows.Forms.View.Details;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 469);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDbPath);
            this.Controls.Add(this.panel);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstdb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 打开数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 新建数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设计表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 清空表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lstStructure;
        private System.Windows.Forms.ListView lstContent;


    }
}

