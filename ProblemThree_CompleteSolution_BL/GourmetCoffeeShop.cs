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
            get { return this.TotalBillValue; }
            set { this.TotalBillValue = value; }
        }
        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice) : base(iCode, iName, iPrice)
        {
            this.TotalBillValue = 0;
        }
        public override double PayPerPiece(int quantity)
        {
            this.TotalBillValue = quantity * this.ItemPrice[this.ItemCode];
            return this.TotalBillValue;
        }
        public override double PayPerWeight(int weight)
        {
            this.TotalBillValue = weight * this.ItemPrice[this.ItemCode];
            return this.TotalBillValue;

        }

        public double TaxOnTotalBill()
        {
            return 0.05 * this.TotalBillValue;
        }
    }
}
