using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double TotalBillValue
        {
            get;
            set;
        }
        

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int, double> iPrice) : base (iCode, iName, iPrice)
        {
            this.TotalBillValue = 0;
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
