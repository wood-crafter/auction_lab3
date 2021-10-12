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
    public partial class Bid : Form
    {
        public Bid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBidForm.Enabled = false;
            txtItemDescription.Enabled = false;
            txtCurrentPrice.Enabled = false;
            txtEdt.Enabled = false;
            txtSeller.Enabled = false;
            txtMbi.Enabled = false;
            //txtTime.Enabled = false;
            LoadBidder();
            LoadItem();
            cbxItem.SelectedIndex = 1;
            timer1.Enabled = true;
            timer1.Start();
            labelTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");


        }
        private void LoadBidder()
        {
            DataProvider dataProvider = new DataProvider();
            DataTable dt = dataProvider.executeQuery("SELECT MemberId,NAME FROM MEMBERS");
            cbxBidder.DataSource = dt;
            cbxBidder.DisplayMember = "NAME";
            cbxBidder.ValueMember = "MemberId";
        }
        private void LoadItem()
        {
            DataProvider dataProvider = new DataProvider();
            string sql = "SELECT ItemID,ItemName FROM Items WHERE Items.EndDateTime > GETDATE()";
            DataTable dt = dataProvider.executeQuery(sql);
            cbxItem.DataSource = dt;
            cbxItem.DisplayMember = "ItemName";
            cbxItem.ValueMember = "ItemID";
        }

        private void cbxBidder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string item = cbxItem.SelectedValue.ToString();
                DataProvider dataProvider = new DataProvider();
                string sql = "Select * from Items join Members on Items.SellerID=Members.MemberId"
                                                          + " Where ItemID = '" + item + "'";
                DataTable dt = dataProvider.executeQuery(sql);
                txtItemDescription.Text = dt.Rows[0][3].ToString();
                txtCurrentPrice.Text = dt.Rows[0][7].ToString();
                txtEdt.Text = dt.Rows[0][6].ToString();
                txtSeller.Text = dt.Rows[0][9].ToString();
                txtMbi.Text = dt.Rows[0][5].ToString();

            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            String stringDate = txtEdt.Text;
            DateTime dateTime = DateTime.Parse(stringDate);
            System.TimeSpan diff2 = dateTime - DateTime.Now;
            labelTimeRe.Text = diff2.Days.ToString() + ". " + diff2.Hours.ToString() + ":" + diff2.Minutes.ToString();

        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBidPirce.Text) >= Convert.ToDouble(txtCurrentPrice.Text) + Convert.ToDouble(txtMbi.Text))
                {
                    DataProvider dataProvider = new DataProvider();

                    string sql = "INSERT INTO [dbo].[Bids]"
                + " ([ItemID] ,[BidderID]  ,[BidDateTime] ,[BidPrice])"
                + "   VALUES "
                + "(" + cbxItem.SelectedValue.ToString() + ","
                + cbxBidder.SelectedValue.ToString() + ","
                + "'" + labelTime.Text + "',"
                + Convert.ToDouble(txtBidPirce.Text) + ")";

                    string updateCurrentPriceSql = "UPDATE Items SET CurrentPrice = " + Convert.ToDouble(txtBidPirce.Text) +  "WHERE ItemID = " + cbxItem.SelectedValue.ToString();
                    try
                    {
                        dataProvider.executeNonQuery(sql);
                        dataProvider.executeNonQuery(updateCurrentPriceSql);
                        MessageBox.Show("Bid item is added!");
                        //MessageBox.Show(sql);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    double minBidPrice = Convert.ToDouble(txtCurrentPrice.Text) + Convert.ToDouble(txtMbi.Text);
                    MessageBox.Show("Bid price must be >=" + Convert.ToDouble(minBidPrice));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnPlaceForm_Click(object sender, EventArgs e)
        {
            Place place = new Place();
            this.Hide();
            place.ShowDialog();
            this.Close();
        }

        private void btnDisplayForm_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            this.Hide();
            display.ShowDialog();
            this.Close();
        }
    }
}
