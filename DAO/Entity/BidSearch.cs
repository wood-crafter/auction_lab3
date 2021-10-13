using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class BidSearch
    {
         string bdate;
         string edate;
         double bidprice;
         string bidname;
         string timeremaining;


        public BidSearch()
        {
        }

        public BidSearch(string bdate, string edate, double bidprice, string bidname, string timeremaining)
        {
            this.bdate = bdate;
            this.edate = edate;
            this.bidprice = bidprice;
            this.bidname = bidname;
            this.timeremaining = timeremaining;
        }

        public string Bdate { get => bdate; set => bdate = value; }
        public string Edate { get => edate; set => edate = value; }
        public double Bidprice { get => bidprice; set => bidprice = value; }
        public string Bidname { get => bidname; set => bidname = value; }
        public string Timeremaining { get => timeremaining; set => timeremaining = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
