using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Courswork.Classes
{
    public class Order
    {
        int orderID;
        DateTime orderDate;
        int customerID;
        int costumeID;

        public Order()
        {
        }

        public Order(int orderID, DateTime orderDate, int customerID, int costumeID)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.customerID = customerID;
            this.costumeID = costumeID;
        }

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int CostumeID
        {
            get { return costumeID; }
            set { costumeID = value; }
        }
    }
}
