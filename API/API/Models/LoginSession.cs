using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class LoginSession
    {
        private int user_id;
        private string sessionCode;
        private DateTime start_of_session;

        public string CreateSession(int user_id)
        {
            sessionCode = RandomString(30);

            DbConnect dbConnect = new DbConnect();
            dbConnect.PutSessionToDB(user_id, sessionCode, DateTime.Now);
            return sessionCode;
        }

        public void DeleteSession(int user_id, string sessionCode)
        {
            DbConnect dbConnect = new DbConnect();
            dbConnect.DELETESessionInDB(user_id, sessionCode);
        }
        public void UpdateSession(int user_id, string sessionCode)
        {

        }

        // TODO: find better way to make session Codes
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}