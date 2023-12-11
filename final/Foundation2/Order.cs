using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Order
    {
        Customer _customer;
        List<Product> _productList=new List<Product>();
        

        public void CreateDemoProducts(int productSet)
        {
            if (productSet==0)
            {                
                _productList.Add(new Product("Roller Bearing", "SK-345",14.58,12));
                _productList.Add(new Product("Bushing", "XK4-16",22.46,8));
                _productList.Add(new Product("Linear Rail", "451278",83.45,4));                
            }
            if (productSet==1)
            {                
                _productList.Add(new Product("Bolt", "BY425",0.46,32));
                _productList.Add(new Product("Grease", "GL16",14.00,6));
                _productList.Add(new Product("Motor", "BLD480",224.08,1));                                
            }

        }

        public double GetTotalCost()
        {
            double output=0;
            foreach (Product product in _productList) output += product.GetCost();
            return output;
        }

        public void CreateDemoCustomer(int customerSet)
        {
            if (customerSet == 0) _customer=new Customer("Brown Engineering","3120 Heatherton Dr","Florissant","Missouri","USA");
            if (customerSet == 1) _customer=new Customer("SGB Innovations","5174 W Canyon Rose Cir","Herriman","Utah","USA");
        }


        public string GetPackingLabel()
        {
            string output="Name ID Quanity Price";
            foreach (Product product in _productList) output += "\n" + product.GetPackingLine();
            return output;
        }

        public string GetShippingLabel()
        {
            return _customer.GetShippingLabel();
        }

    }

    
}