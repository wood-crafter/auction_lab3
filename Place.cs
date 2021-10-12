using System;
using System.Collections;
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
    public partial class Place : Form
    {
        public Place()
        {
            InitializeComponent();
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

        bool check()
        {
            if (tbItemName.Text.Length == 0 || tbCurrentPrice.Text.Length == 0 || tbItemDes.Text.Length == 0 || txtMinumum.Text.Length == 0)
            {
                MessageBox.Show("Please fill all ");
                return false;
            }
            return true;
        }
        private void btnPlace_Click(object sender, EventArgs e)
        {
            /*int itemtype = Convert.ToInt32(cbItemType.SelectedValue.ToString());
            string itemname = tbItemName.Text.Trim();
            string itemdes = tbItemDes.Text.Trim();
            int sellerid = Convert.ToInt32(cbSeller.SelectedValue.ToString());
            float minimumbid = (float)Convert.ToDouble(txtMinumum.Text.Trim());
            DateTime date = dtPDateTime.Value;
            float currentprice = (float)Convert.ToDouble(tbCurrentPrice.Text.Trim());
            ArrayList arrayList = new ArrayList() { itemtype, itemname, itemdes, sellerid, minimumbid, date, currentprice };
            if (!check())
            {
                return;
            }
            else if (addItem.AddPlace(arrayList) > 0)
            {
                MessageBox.Show("Add subject successed");

            }
            else
            {
                MessageBox.Show("Add subject failed");
            }*/

            try
            {
                if (!check())
                {
                    Console.WriteLine(txtMinumum);
                    DataProvider dataProvider = new DataProvider();
                    string sql = "INSERT INTO [dbo].[Items] ([ItemTypeID],[ItemName],[ItemDescription],[SellerID],[MinimumBidIncrement],[EndDateTime]),[CurrentPrice] " +
                    "VALUES "
                    + "(" + cbItemType.SelectedValue.ToString() + ","
                    + tbItemName.Text + ","
                    + tbItemDes.Text + ","
                    + cbSeller.SelectedValue.ToString() + ","
                    + txtMinumum.Text.ToString() + ","
                    + dtPDateTime.Value + ","
                    + tbCurrentPrice.Text.ToString() + ")";
                    
                    try
                    {      
                        
                        dataProvider.executeNonQuery(sql);                      
                        MessageBox.Show("Added");

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch
            {     
                
                MessageBox.Show("alo");
            }
        }
      

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
