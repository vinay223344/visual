using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstlab
{
    class Stock
    {
        string s_name, sym_name;
        double prev_price, curr_price;
        public Stock(string name, string sym_name, double prev_price, double curr_price)
        {
            s_name = name;
            this.sym_name = sym_name;
            this.prev_price = prev_price;
            this.curr_price = curr_price;
        }
        public double getChangePercentage()
        {
            return (curr_price - prev_price) / prev_price * 100;
        }

    }
}
