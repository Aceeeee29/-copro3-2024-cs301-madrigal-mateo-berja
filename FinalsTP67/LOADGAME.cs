using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FinalsTP67
{
    public class LoadGame
    {

        public void LoadMenu()
        {
            Console.Clear();
            Console.WriteLine("Load Game:\n");

            Console.WriteLine("1. See created Characters");
            Console.WriteLine("2. Delete Character");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    LoadTheGame();
                    break;

                case "2": 
                    DeleteLoad();
                    break;

                default:
                    Console.WriteLine("\nInvalid selection. Please choose a valid option (1-2).");
                    break;
            }
        }



        public void LoadTheGame()
        {
            Console.Clear();
            SqlConnection ConnectionNaMaangas;
            string databaseconnectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""D:\PROGRAMMING\2ND YEAR COMPROG\FINALSTP3\FINALSTP67\DATABASE1.MDF"";Integrated Security=True";

            try
            {
                ConnectionNaMaangas = new SqlConnection(databaseconnectionstring);
                ConnectionNaMaangas.Open();
                string query = "SELECT * FROM dbo.PIZZA;";

                SqlCommand command = new SqlCommand(query, ConnectionNaMaangas);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    for (int i = 0; i < reader.FieldCount; i++)
                    {

                        Console.WriteLine(reader[i]);
                    }
                }
                reader.Close();
                ConnectionNaMaangas.Close();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void DeleteLoad()

        {
            Console.Clear();
            SqlConnection ConnectionNaMaangas;
            string databaseconnectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""D:\PROGRAMMING\2ND YEAR COMPROG\FINALSTP3\FINALSTP67\DATABASE1.MDF"";Integrated Security=True";
            try
            {
                using (ConnectionNaMaangas = new SqlConnection(databaseconnectionstring))
                {
                    ConnectionNaMaangas.Open();

                    string query = "DELETE FROM dbo.PIZZA WHERE user_Id = @user_Id";
                    Console.Write("Enter the User ID to delete: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    using (SqlCommand command = new SqlCommand(query, ConnectionNaMaangas))
                    {

                        command.Parameters.AddWithValue("@user_Id", input);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("No row found in the database");
                        }

                    }
                    string resetQuery = "DBCC CHECKIDENT ('dbo.PIZZA', RESEED, 1)";

                    using (SqlCommand resetCommand = new SqlCommand(resetQuery, ConnectionNaMaangas))
                    {
                        resetCommand.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}
