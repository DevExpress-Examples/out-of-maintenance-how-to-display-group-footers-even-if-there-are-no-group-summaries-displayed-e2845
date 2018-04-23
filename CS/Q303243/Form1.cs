using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Q303243 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("Payment", typeof(decimal));
            for(int i = 1; i < 30; i++)
                tbl.Rows.Add(i, string.Format("Item{0}", i % 7), DateTime.Now.AddDays(-60).AddDays(i), i * 3.3);
            gridControl1.DataSource = tbl;
            gridView1.Columns["Name"].GroupIndex = 0;
            gridView1.ExpandAllGroups();
            gridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Payment", gridView1.Columns["Payment"]);
            gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
        }
    }
}