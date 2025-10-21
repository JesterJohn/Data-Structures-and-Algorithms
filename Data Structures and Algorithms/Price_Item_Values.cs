using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal class Price_Item_Values
    {
        public String price, itemname, discount_amt;

        public void SetPriceItemvalue(string item_name, string item_price)
        {
            this.itemname = item_name;
            this.price = item_price;
        }
        public String GetItemName()
        {   
            return itemname; 
        }
        public String GetPrice()
        {
            return price;
        }
        public void SetPriceDiscountAmountValue(string discount_amt,string priceItem)
        {
            this.price = priceItem;
            this.discount_amt = discount_amt;
        }
        public String GetPriceItem()
        {
            return price;
        }
        public String GetDiscountAmount()
        { 
            return discount_amt;        
        }
    }
}