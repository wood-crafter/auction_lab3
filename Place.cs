using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Place : Form
    {
        public Place()
        {
            InitializeComponent();
            btnPlaceForm.Enabled = false;
            DataTable dt = DAO.GetDataTable("SELECT * FROM Members");
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            cbSeller.DataSource = dt;
            cbSeller.DisplayMember = "Name";
            cbSeller.ValueMember = "MemberID";
            cbSeller.SelectedValue = 1;

            cbItemType.DataSource = DAO.GetDataTable("SELECT * FROM Items");
            cbItemType.DisplayMember = "ItemName";
            cbItemType.ValueMember = "ItemTypeID";
            cbItemType.SelectedValue = 1;
         

            dtPDateTime.Format = DateTimePickerFormat.Custom;
            dtPDateTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        bool check(string tbItemName,string tbCurrentPrice,string tbItemDes,string txtMinumum)
        {
            if (tbItemName == ""|| tbCurrentPrice == "" || tbItemDes == "" || txtMinumum == "")
            {
                MessageBox.Show("Please fill all ");
                return false;
            }
           
            Regex regex = new Regex(@"^[0-9]+\.?[0-9]*$");

            if (!regex.IsMatch(tbCurrentPrice))
            {
                MessageBox.Show("Current price must be a double !");
                return false;
            }
            if (!regex.IsMatch(txtMinumum))
            {
                MessageBox.Show("Mininum bid increment must be a double !");
                return false;
            }
            return true;
        }
        private void btnPlace_Click(object sender, EventArgs e)
        {
            int itemtype = Convert.ToInt32(cbItemType.SelectedValue.ToString());
            string itemname = tbItemName.Text.Trim();
            string itemdes = tbItemDes.Text.Trim();
            string sellerid =cbSeller.SelectedValue.ToString();
            string minimumbid = txtMinumum.Text.Trim();
            DateTime date = dtPDateTime.Value;
            string currentprice = tbCurrentPrice.Text.Trim();
            try
            {
               if (check(itemname,currentprice,itemdes,minimumbid))
               {
                    int seller = Convert .ToInt32(sellerid);
                    float minimum = (float)Convert.ToDouble(minimumbid);
                    float current = (float)Convert.ToDouble(currentprice);
                    DataProvider dataProvider = new DataProvider();
                    string sql = "INSERT INTO dbo.Items(ItemTypeID,ItemName,ItemDescription,SellerID,MinimumBidIncrement,EndDateTime,CurrentPrice )VALUES ( " + itemtype + ", '" + itemname + "', '"  + itemdes + "', " + seller + ", " + minimum + ", '" + date + "', " + current + ")" ;
                     dataProvider.executeNonQuery(sql);
                    cbItemType.SelectedValue = 1;
                    cbSeller.SelectedValue = 1;
                    txtMinumum.Clear();
                    tbCurrentPrice.Clear();
                    tbItemDes.Clear();
                    tbItemName.Clear();                   
                    MessageBox.Show("Add item successed");
                }

    }
            catch (SqlException ex)
            {
                MessageBox.Show("Add item failed");
            }
        }
      

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBidForm_Click(object sender, EventArgs e)
        {
            Bid bid = new Bid();
            this.Hide();
            bid.ShowDialog();
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
