using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsAssignment
{
    internal class Order
    {
        public int OrderId;
        public string CustomerName;
        public int Quantity;
        public decimal UnitPrice;
        public decimal TotalPrice;
        public bool IsPaid;
        public double DiscountPercent;
        public string ShippingCity;
        public char Priority;      // 'H', 'M', or 'L'
        public long ItemCode;

        
        public void CalculateTotal()
        {
            decimal discount = (decimal)(1 - (DiscountPercent / 100));
            TotalPrice = Quantity * UnitPrice * discount;
        }

        
        public void PrintSummary()
        {
            Console.WriteLine(
                $"Order #{OrderId} | Customer: {CustomerName} | Total: {TotalPrice:C} | Paid: {IsPaid}"
            );
        }


    }
}
