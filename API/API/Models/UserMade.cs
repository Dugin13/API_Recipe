using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class UserMade
    {
        private int userId;
        private int recipeId;
        private DateTime madeData;

        public void MadeRecipeNow(int recipeId, int userId)
        {
            DbConnect dbConnect = new DbConnect();
            dbConnect.POSTUserMadeInDB(recipeId, userId, DateTime.Now);
        }
        public void MadeRecipeBefore(int recipeId, int userId, DateTime madeData)
        {
            DbConnect dbConnect = new DbConnect();
            dbConnect.POSTUserMadeInDB(recipeId, userId, madeData);
        }
    }
}