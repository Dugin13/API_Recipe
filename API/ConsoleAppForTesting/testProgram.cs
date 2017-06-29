using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTesting
{
    class testProgram
    {
        private static string temp;
        static void Main(string[] args)
        {
            //RefTest();
            //FileReadTest();

            string x = "";

            Console.WriteLine("x for ending tests" + System.Environment.NewLine +
                    "1 making a user" + System.Environment.NewLine +
                    "2 checking if user name is used" + System.Environment.NewLine +
                    "3 put new loginSession" + System.Environment.NewLine +
                    "4 delate loginSession made in test 3" + System.Environment.NewLine +
                    "5 adding new product to DB" + System.Environment.NewLine +
                    "6 adding new UserMade");

            while (x != "x")
            {
                x = Console.ReadLine();
                switch (x)
                {
                    case "x":
                        break;

                    case "1":
                        DBTestMakeUser();
                        break;

                    case "2":
                        TBTest_CheckForUserNameExistInDB();
                        break;

                    case "3":
                        TBTest_PutSessionToDB();
                        break;

                    case "4":
                        TBTest_DeleteSessionInDB();
                        break;

                    case "5":
                        TBTest_AddProductToDB();
                        break;

                    case "6":
                        TBTest_MadeRecipeNow();
                        break;

                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
                Console.WriteLine("----");
            }
        }
        private static void TBTest_()
        {

        }

        private static void DBTestMakeUser()
        {
            Console.WriteLine("Write user name");
            string userName = Console.ReadLine();
            Console.WriteLine("Write user password");
            string userPassword = Console.ReadLine();

            DbConnect dbConnect = new DbConnect();

            dbConnect.POSTUserInDB(userName, userPassword);
        }

        // not done
        private static void DBTest_ChaneUserPassword()
        {
            Console.WriteLine("Write user name");
            string userName = Console.ReadLine();
            Console.WriteLine("Write user password");
            string userPassword = Console.ReadLine();
            DbConnect dbConnect = new DbConnect();


        }
        private static void TBTest_CheckForUserNameExistInDB()
        {
            Console.WriteLine("Write user name");
            string userName = Console.ReadLine();
            DbConnect dbConnect = new DbConnect();
            bool x = dbConnect.GETForUserNameExistInDB(userName);
            Console.WriteLine(x);
        }
        private static void TBTest_PutSessionToDB()
        {
            LoginSession loginSession = new LoginSession();

            temp = loginSession.CreateSession(1);

        }
        private static void TBTest_DeleteSessionInDB()
        {
            LoginSession loginSession = new LoginSession();

            loginSession.DeleteSession(1, temp);
        }
        private static void TBTest_AddProductToDB()
        {
            Console.WriteLine("wtite product name");
            string product = Console.ReadLine();
            DbConnect dbConnect = new DbConnect();
            dbConnect.POSTProductToDB(product);
        }
        private static void TBTest_MadeRecipeNow()
        {
            UserMade userMade = new UserMade();
            userMade.MadeRecipeNow(-1, 1);


        }
    }
}
