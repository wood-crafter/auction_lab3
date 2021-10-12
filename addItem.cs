using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lab3
{
   
    class addItem
    {
        private int itemTypeID;
        private string itemName;
        private string itemDes;
        private int sellerID;
        private float minimumBid;
        private DateTime endDateTime;
        private float currentPrice;

        
        public addItem(int itemTypeID, string itemName, string itemDes, int sellerID, float minimumBid, DateTime endDateTime, float currentPrice)
        {
            this.itemTypeID = itemTypeID;
            this.itemName = itemName;
            this.itemDes = itemDes;
            this.sellerID = sellerID;
            this.minimumBid = minimumBid;
            this.endDateTime = endDateTime;
            this.currentPrice = currentPrice;
        }

        public addItem()
        {
        }

        public int ItemTypeID { get => itemTypeID; set => itemTypeID = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemDes { get => itemDes; set => itemDes = value; }
        public int SellerID { get => sellerID; set => sellerID = value; }
        public float MinimumBid { get => minimumBid; set => minimumBid = value; }
        public DateTime EndDateTime { get => endDateTime; set => endDateTime = value; }
        public float CurrentPrice { get => currentPrice; set => currentPrice = value; }

     /*   public static int AddPlace(ArrayList arrayList)
        {
            string sql = "INSERT INTO [dbo].[Items]([ItemTypeID],[ItemName],[ItemDescription],[SellerID],[MinimumBidIncrement],[EndDateTime]),[CurrentPrice] " +
                "VALUES (@itemtypeid,@itemname,@itemDescription,@sellerid,@minimum,@enddatetime,@currentprice)";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@itemtypeid",SqlDbType.Int),               
                 new SqlParameter("@itemname",SqlDbType.NVarChar),
                 new SqlParameter("@itemDescription",SqlDbType.NVarChar),
                  new SqlParameter("@sellerid",SqlDbType.Int),
                   new SqlParameter("@minimum",SqlDbType.Float),
                    new SqlParameter("@enddatetime",SqlDbType.DateTime),
                    new SqlParameter("@currentprice",SqlDbType.Float)




            };
            for (int i = 0; i < arrayList.Count; i++)
            {
                sqlParameter[i].Value = arrayList[i];
            }
            return DataProvider.ExecuteSQL(sql, sqlParameter);
        }*/
    }
}
