using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Product
    {
        private int product_id;
        private string product_name;

        public void AddProduct(string product_name)
        {
            DbConnect dbConnect = new DbConnect();
            dbConnect.POSTProductToDB(product_name);
        }
    }


}