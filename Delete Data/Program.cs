﻿using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;"; // Replace with your actual connection string

    static void DeleteContact(int ContactID)
    {


        SqlConnection connection = new SqlConnection(connectionString);
        
        string query = @"Delete Contacts 
                                where ContactID = @ContactID";

        SqlCommand command = new SqlCommand(query, connection);
            
                command.Parameters.AddWithValue("@ContactID", ContactID);
               
                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Record Deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Record Delete failed.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            
        
    }

    public static void Main()
    {

       
        DeleteContact(9);

        Console.ReadKey();

    }

}
