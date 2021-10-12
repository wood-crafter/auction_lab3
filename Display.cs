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
            btnDisplayForm.Enabled = false;
        }
        private void bindGrid1(string id)
        {
            try
            {
                string dateNow = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
                DataProvider dataProvider = new DataProvider();
                DataTable dt = dataProvider.executeQuery("select A.BidDateTime, A.BidPrice, A.Bidder,(I.EndDateTime - '"+dateNow+"') as TimeRemaining from " +
                    "(SElECT BidDateTime, BidPrice,Name as Bidder,B.ItemID from Bids B join Members M on B.BidderID = M.MemberId)" +
                    " as A join Items I on A.ItemID = I.ItemID where A.ItemID = "+id+" order by A.BidPrice desc");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].DefaultCellStyle.Format = "dd, HH:mm";
            }
            catch
            {

            }
        }
        private void cbxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxItem.DataSource=null;
                cbxItem.Items.Clear();
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
            string id = cbxItem.SelectedValue.ToString();
            try
            {
                bindGrid1(id);
            }
            catch
            {

            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblNo.Text = dataGridView1.Rows.Count.ToString();
        }

        private void btnBidForm_Click(object sender, EventArgs e)
        {
            Bid bid = new Bid();
            this.Hide();
            bid.ShowDialog();
            this.Close();
        }

        private void btnPlaceForm_Click(object sender, EventArgs e)
        {
            Place place = new Place();
            this.Hide();
            place.ShowDialog();
            this.Close();
        }
    }
}
