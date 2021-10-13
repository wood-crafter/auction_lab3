using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        }
        /*private void bindGrid1(string id)
        {
            try
            {
                DataProvider dataProvider = new DataProvider();
                DataTable dt = dataProvider.executeQuery("select A.BidDateTime, A.BidPrice, A.Bidder,(I.EndDateTime - A.BidDateTime) as TimeRemaining from " +
                    "(SElECT BidDateTime, BidPrice,Name as Bidder,B.ItemID from Bids B join Members M on B.BidderID = M.MemberId)" +
                    " as A join Items I on A.ItemID = I.ItemID where A.ItemID = " + id + " order by A.BidPrice desc");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].DefaultCellStyle.Format = "dd, HH:mm";
            }
            catch
            {

            }
        }*/
      
        public List<BidSearch> bindGrid1(string id)
        {
            List<BidSearch> list = new List<BidSearch>();

            DataProvider dataProvider = new DataProvider();
            SqlDataReader rd = dataProvider.executeQuery1("select A.BidDateTime, A.BidPrice, A.Bidder,I.EndDateTime from " +
                "(SElECT BidDateTime, BidPrice,Name as Bidder,B.ItemID from Bids B join Members M on B.BidderID = M.MemberId)" +
                " as A join Items I on A.ItemID = I.ItemID where A.ItemID = " + id + " order by A.BidPrice desc");
            while (rd.Read())
            {
                string bidDate = rd.GetValue(0).ToString().Trim();
                string endDate = rd.GetValue(3).ToString().Trim();
                double bidPrice = double.Parse(rd.GetValue(1).ToString().Trim());
                string bidderName = rd.GetValue(2).ToString().Trim();
                DateTime bdate = DateTime.Parse(bidDate);
                DateTime edate = DateTime.Parse(endDate);
                TimeSpan df = (edate - bdate);
                string timeremain = df.Days + ", " + df.Hours + ":" + df.Minutes;
                list.Add(new BidSearch(bidDate, endDate, bidPrice, bidderName,timeremain));
            }
            return list;
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
             List<BidSearch> list = bindGrid1(id);
            int count;
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "BidDateTime";
            dataGridView1.Columns[1].Name = "BidPrice";
            dataGridView1.Columns[2].Name = "Bidder";
            dataGridView1.Columns[3].Name = "TimeRemaining\n(dd, HH:mm)";
            foreach (BidSearch b in list)
                {
                DateTime date = DateTime.Parse(b.Bdate);

                string dateFormat = date.ToString("dd/M/yyyy hh:mm:ss tt");

                dataGridView1.Rows.Add(dateFormat, b.Bidprice,b.Bidname,b.Timeremaining); 
                }
            lblNo.Text = " " + list.Count;
            if (list.Count == 0)
            {
                MessageBox.Show("Dont have data for this item");
            }
            /*  try
              {   
                  bindGrid1(id);
              }
              catch
              {

              }*/
        }

    }
}
