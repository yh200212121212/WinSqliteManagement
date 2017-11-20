using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSqliteManagement
{
    public partial class MainFrm : Form
    {
        private DbXmlInfo xmlInfo = null;

        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            var list = DbXmlHelper.GetList();
            this.Invoke(new Action<ListBox>(p =>
            {
                foreach (var item in list)
                {
                    p.Items.Add(item.Name);
                }
            }), this.lstdb);

            this.lstStructure.Columns.Add("索引", 60, HorizontalAlignment.Left);
            this.lstStructure.Columns.Add("列名", 120, HorizontalAlignment.Left);
            this.lstStructure.Columns.Add("类型", 90, HorizontalAlignment.Left);
            this.lstStructure.Columns.Add("非空", 60, HorizontalAlignment.Left);
            this.lstStructure.Columns.Add("主键", 60, HorizontalAlignment.Left);
        }

        private void lstdb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstdb.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string name = lstdb.Items[index].ToString();

                this.xmlInfo = DbXmlHelper.GetItem(name);
                if (this.xmlInfo != null)
                {
                    var tableList = DbManager.ReadAllTables(this.xmlInfo.Path, this.xmlInfo.Pwd);
                    this.Invoke(new Action<ListBox>(p =>
                    {
                        foreach (var table in tableList)
                        {
                            p.Items.Add(table);
                        }
                    }), this.lstTables);
                }
            }
        }

        private void lstTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstTables.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string tableName = lstTables.Items[index].ToString();

                var strList = DbManager.ReadTableStructure(this.xmlInfo.Path, this.xmlInfo.Pwd, tableName);

                List<string> columnList = new List<string>();
                this.Invoke(new Action<ListView>(p =>
                {
                    foreach (var str in strList)
                    {
                        var array = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        if (array.Length == 5)
                        {
                            ListViewItem item = new ListViewItem(array[0]);

                            string[] values = new string[array.Length - 1];
                            item.SubItems.AddRange(new string[] { array[1], array[2], array[3], array[4] });

                            p.Items.Add(item);
                            columnList.Add(array[1]);
                        }
                    }
                }), this.lstStructure);
                // 用一个窗口解析结构，一个窗口解析表内容

                var ds = DbManager.ReadTableContent(this.xmlInfo.Path, this.xmlInfo.Pwd, tableName);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    this.lstContent.Items.Clear();
                    this.lstContent.Columns.Clear();
                    DataTable dt = ds.Tables[0];
                    foreach (DataColumn dc in dt.Columns)
                    {
                        this.lstContent.Columns.Add(dc.ColumnName, 100, HorizontalAlignment.Left);
                    }

                    this.Invoke(new Action<ListView>(p =>
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            List<string> list = new List<string>();
                            foreach (object obj in dr.ItemArray)
                            {
                                list.Add(obj.ToString());
                            }

                            ListViewItem item = new ListViewItem(list.ToArray());
                            p.Items.Add(item);
                            string str = string.Join("','", list.ToArray());
                        }
                    }), this.lstContent);
                }
            }
        }
    }
}
