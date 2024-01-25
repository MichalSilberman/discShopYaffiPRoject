using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class ShoppingCart
    {
        
        public int IddISC { get; set; }

        public string NameDisc { get; set; }

        public int count { get; set; }

        public double pricePerUnit { get; set; }

        public double sum { get; set; }

        public ShoppingCart(int IddISC, string NameDisc, int count, double pricePerUnit, double sum)
        {
            this.IddISC = IddISC;
            this.NameDisc = NameDisc;
            this.count = count;
            this.pricePerUnit = pricePerUnit;
            this.sum = sum;

        }
        public ShoppingCart()
        {
            this.IddISC = IddISC;
            this.NameDisc = NameDisc;
            this.count = count;
            this.pricePerUnit = pricePerUnit;
            this.sum = sum;

        }
    }
}
