using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Courswork.Classes
{
    public class Supplier
    {
        int supplierID;
        string supplierName;

        public Supplier()
        {
        }

        public Supplier(int supplierID, string supplierName)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
        }

        public int SuppllierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }
    }
}
