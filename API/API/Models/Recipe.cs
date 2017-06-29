using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Recipe
    {
        private int recipe_id;
        private string recipe_name;
        private int recipe_author;
        private string recipe_description;

        public void CreateRecipe(string recipe_name,
                                 int recipe_author,
                                 string recipe_description,
                                 List<Product> product)
                                 
        {

        }
        public void ChanceRecipe(int recipe_id, string recipe_description, List<Product> product)
        {

        }

    }
}