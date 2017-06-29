using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    // is automade when adding a Recipe. Therefore this have no functions
    public class RecipeContent
    {
        public int recipe_content_recipe_id;
        public int recipe_content_product_id;
        public double recipe_content_amount;
        public string recipe_content_measure_method;
    }
}