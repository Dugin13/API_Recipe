using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class User
    {
        private int id;
        private string name;
        private string password;

        public void CreateUser(string name, string password)
        {
            DbConnect dbConnect = new DbConnect();
            dbConnect.POSTUserInDB(name, password);
        }

        // need to work with LoginSession.CreateSession
        public bool LoginUser()
        {
            return false;
        }

        public void LogOutUser()
        {

        }
        public void ChanceUserCode()
        {

        }
    }
}