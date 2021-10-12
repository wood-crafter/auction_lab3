using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            DataProvider dataProvider = new DataProvider();
            DataTable dt = dataProvider.executeQuery("SELECT * FROM members");
            cbxMember.DataSource = dt;
            cbxMember.DisplayMember = "Name";
            cbxMember.ValueMember = "MemberID";
            bindGrid1();
        }
        private void bindGrid1()
        {

            DataProvider dataProvider = new DataProvider();
            DataTable dt = dataProvider.executeQuery("SELECT * FROM bids");
            DataView dv = new DataView(dt);
            try
            {
                /*string filter = "";
                if (((int)comboBox1.SelectedValue) != -1)
                    filter = "itemID = " + comboBox1.SelectedValue.ToString();
                if (filter != "") filter += " AND bidderID IN (";
                else filter += "bidderID IN (";
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    DataRowView rv = (DataRowView)listBox1.SelectedItems[i];
                    filter += rv["memberID"].ToString();
                    if (i < listBox1.SelectedItems.Count - 1)
                        filter += ",";
                }
                filter += ")";
                //MessageBox.Show(filter);                
                dv.RowFilter = filter;
                dv.Sort = "BidPrice DESC";*/
                dataGridView1.DataSource = dv;
            }
            catch
            {

            }
        }
        private void cbxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = cbxMember.SelectedValue.ToString();
                DataProvider dataProvider = new DataProvider();
                DataTable dt = dataProvider.executeQuery("SELECT * FROM Items where SellerID = " + id);
                cbxItem.DataSource = dt;
                cbxItem.DisplayMember = "ItemName";
                cbxItem.ValueMember = "ItemID";
            }
            catch
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblNo.Text = dataGridView1.Rows.Count.ToString();
        }
    }
}
