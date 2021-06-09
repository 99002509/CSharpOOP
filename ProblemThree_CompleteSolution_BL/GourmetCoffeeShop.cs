using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public double TotalBillValue
        {
            get;
            set;
        }
        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int,double> iPrice)
        {
            this.ItemCode = iCode;
            this.ItemName = iName;
            this.ItemPrice = iPrice;
        }
        public override double PayPerPiece(int quantity)
        {
            TotalBillValue = quantity * this.ItemPrice[this.ItemCode];
            return TotalBillValue;
        }
        public override double PayPerWeight(int weight)
        {
            TotalBillValue = weight * this.ItemPrice[this.ItemCode];
            return TotalBillValue;

        }

        public double TaxOnTotalBill()
        {
            return 0.05 * TotalBillValue;
        }
    }
}
