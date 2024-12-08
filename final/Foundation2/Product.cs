using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Product
    {
        string _name="";
        string _productID="";
        double _price=0;
        double _quantity=0;

        public Product(string name, string productID, double price, double quantity)
        {
            _name = name;
            _productID = productID;
            _price = price;
            _quantity = quantity;
        }

        public string GetPackingLine()
        {
            return $"{_name} {_productID} {_quantity} ${_price}";
        }

        public double GetCost()
        {
            return _quantity * _price;
        }

    }
}