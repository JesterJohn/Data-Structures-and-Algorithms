using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal class Price_Item_Value
    {
        public String price, itemname, discount_amt;
        public void SetPriceItemValue(string item_name, string item_price)
        {
            itemname = item_name;
            price = item_price;
        }
        public String GetItemName()
        {
            return itemname;
        }
        public String GetPrice()
        {
            return price;
        }
        public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)
        {
            this.discount_amt = discount_amt;
            price = priceItem;
        }
        public String GetItemPrice()
        {
            return price;
        }
        public String GetDiscountAmount()
        {
            return discount_amt;
        }
       

    }
}
