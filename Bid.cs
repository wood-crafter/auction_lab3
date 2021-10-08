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
    public partial class Bid : Form
    {
        public Bid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataProvider dataProvider = new DataProvider();
            //DataTable dt = dataProvider.executeQuery("SELECT NAME FROM MEMBERS");
            //for(int i = 0; i < dt.Rows.Count; i++)
            //{
            //    cbxBidder.Items.Add(dt.Rows[i].ToString());
            //}


        }

        private void cbxBidder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
