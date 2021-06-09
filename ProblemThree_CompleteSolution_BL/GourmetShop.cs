using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        
        public int ItemCode
        {
            get { return this.ItemCode; }
            set { this.ItemCode = value; }
        }

        public string ItemName
        {
            get { return this.ItemName; }
            set { this.ItemName = value; }
        }

        public Dictionary <int,double> ItemPrice
        {
            get { return this.ItemPrice; }
            set { this.ItemPrice = value; }
        }

        public GourmetShop(int iCode, string iName, Dictionary<int, double> iPrice)
        {
            this.ItemCode = iCode;
            this.ItemName = iName;
            this.ItemPrice = iPrice;
        }

        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);
        

    }
}