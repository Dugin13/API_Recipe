using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class DbConnect
    {
        string connstring;
        MySqlConnection connection;

        public DbConnect()
        {
            connstring = System.IO.File.ReadAllText(@"C:\rod\DBInfo.txt");
            connection = new MySqlConnection(connstring);
        }

        //check
        public void PutSessionToDB(int user_id, string session_code, DateTime start_of_session)
        {
            string query = "INSERT INTO login_session(user_id, start_of_session, session_code)" +
                           "VALUES(" + user_id + ", '" + start_of_session.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + session_code + "');";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //check
        public void DELETESessionInDB(int user_id, string sessionCode)
        {
            string query = "DELETE FROM login_session " +
                           " WHERE user_id = " + user_id + " AND session_code = '" + sessionCode+ "';";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // check
        public void POSTProductToDB(string product_name)
        {
            string query = "INSERT INTO product(product_name)" +
                           "VALUES('" + product_name + "');";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void POSTRecipeAndRecipeContentToDB(string recipe_name,
                                 string recipe_author,
                                 string recipe_main_author,
                                 string recipe_description,
                                 List<RecipeContent> recipeContent)
        {
            int recipe_id;
            string queryForRecipe = "INSERT INTO recipe(recipe_name,recipe_author,recipe_main_author,recipe_description)" +
                           "VALUES('" + recipe_name + "','" + recipe_author + "','" + recipe_main_author + "','" + recipe_description + "');";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryForRecipe, connection);
            //Execute command
            cmd.ExecuteNonQuery();

            recipe_id = (int)cmd.LastInsertedId;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("INSERT INTO recipe(recipe_content_recipe_id," +
                                         "recipe_content_product_id," +
                                         "recipe_content_amount," +
                                         "recipe_content_measure_method) VALUES ");

            for (int i = 0; i < recipeContent.Count; i++)
            {
                sb.Append("(" + recipe_id + "," +  // recipeContent[i].recipeId can not be use since the recipe have just been made in the DB
                    recipeContent[i].recipe_content_product_id + "," +
                    recipeContent[i].recipe_content_amount + ",'" +
                    recipeContent[i].recipe_content_measure_method + "')");

                if (i == (recipeContent.Count - 1))
                {
                    sb.Append(";");
                }
                else
                {
                    sb.Append(",");
                }
            }
            cmd = new MySqlCommand(sb.ToString(), connection);
            //Execute command
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void PUTRecipeAndRecipeContentInDB(int recipe_id,
                                     string recipe_description,
                                     List<RecipeContent> recipeContent)
        {
            string queryForRecipe = "UPDATE recipe SET recipe_description=" + recipe_description + " WHERE recipe_id=" + recipe_id;
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryForRecipe, connection);
            //Execute command
            cmd.ExecuteNonQuery();



            string queryForRecipeContent = "DELETE FROM recipe_content WHERE recipe_id=" + recipe_id;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("INSERT INTO recipe(recipe_content_recipe_id," +
                                         "recipe_content_product_id," +
                                         "recipe_content_amount," +
                                         "recipe_content_measure_method) VALUES ");

            for (int i = 0; i < recipeContent.Count; i++)
            {
                sb.Append("(" + recipe_id + "," +  
                    recipeContent[i].recipe_content_product_id + "," +
                    recipeContent[i].recipe_content_amount + "," +
                    recipeContent[i].recipe_content_measure_method + ")");

                if (i == (recipeContent.Count - 1))
                {
                    sb.Append(";");
                }
                else
                {
                    sb.Append(",");
                }
            }
            cmd = new MySqlCommand(sb.ToString(), connection);
            //Execute command
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        // check
        public void POSTUserInDB(string name, string password)
        {
            string query = "INSERT INTO user (user_name, user_password) " +
                           "VALUES ('" + name + "', '" + password + "');";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // check
        // return true if name is used 
        public bool GETForUserNameExistInDB(string name)
        {
            string query = "SELECT user_name FROM user WHERE user_name = '" + name + "';";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute command
            cmd.ExecuteNonQuery();

            bool temp = cmd.ExecuteReader().Read();
            connection.Close();

            return temp;
        }

        // check
        public void POSTUserMadeInDB(int recipe_id, int user_id, DateTime made_data)
        {
            string query = "INSERT INTO user_made(user_id, recipe_id, made_data)" +
                           "VALUES(" + user_id + ", "+ recipe_id + ", '" + made_data.ToString("yyyy-MM-dd HH:mm:ss")+ "');";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}