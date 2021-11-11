﻿using APPS_Web_APP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web.Helpers;

namespace APPS_Web_APP.Services
{
    public class UsersDAO
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=APPS-Project-Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        User account = new User();


        

        public bool FindUserByNameAndPassword(User user)
        {

            /*
            bool success = false;

            //statement to tell database what to do
            string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username AND password = @password";

            //Keeps it open only while using the database then closes it
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Creates the new command
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 100).Value = user.Password;

                //Checking to see if it worked
                try
                {
                    connection.Open();
                    SqlDataReader reads = command.ExecuteReader();

                    if (reads.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                } */
                
                bool success = false;
                //Creating list to store user salts
                List<String> passwords = null;


                //statement to tell database what to do
                string sqlStatement = "SELECT PASSWORD FROM dbo.Users WHERE USERNAME = @username";

                //Keeps it open only while using the database then closes it
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Creates the new command
                    SqlCommand command = new SqlCommand(sqlStatement, connection);
                    command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;


                    //Checking to see if it worked
                    try
                    {
                        connection.Open();
                        SqlDataReader reads = command.ExecuteReader();

                        while(reads.HasRows && reads.Read())
                        {
                            if(passwords == null) //Initializing list of salts and usernames
                            {
                                passwords = new List<String>();
                            }

                            String password = reads.GetString(reads.GetOrdinal("PASSWORD"));
                            passwords.Add(password);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.Write(e.Message);
                    }
                }
                if(passwords != null)
                {
                    for(int i = 0; i < passwords.Count; i++) 
                    {
  
                        success = Crypto.VerifyHashedPassword(passwords[i], user.Password);
         
                    }
                user.Password = passwords[0];
            }
                  
                return success;
        }

        public void Delete(int Id)
        {
         
            string sqlStatement = "DELETE FROM dbo.Users WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //Adding parameter
                command.Parameters.AddWithValue("@Id", Id);
   

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.Write(e.Message);
                }
                connection.Close();
            }
        }

        public void AddUser(User user)
        {
     
            user.Password = hashPass(user.Password);
            user.Role = 1;
            string sqlStatement = "Insert into dbo.Users(USERNAME, PASSWORD, EMAIL, FIRSTNAME, LASTNAME, ROLE) values(@username, @password, @email, @firstname, @lastname, @role)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //Adding parameter
                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 100).Value = user.Password;
                command.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 100).Value = user.Email;
                command.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar, 40).Value = user.FirstName;
                command.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar, 40).Value = user.LastName;
                command.Parameters.Add("@role", System.Data.SqlDbType.Int).Value = user.Role;
   

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(SqlException e)
                {
                    Console.Write(e.Message);
                }
                connection.Close();
            }
        }

        public bool checkManager(User user)
        {

            bool success = false;


            //statement to tell database what to do
            string sqlStatement = "SELECT * FROM dbo.Users WHERE role = @role";

            //Keeps it open only while using the database then closes it
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Creates the new command
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@role", System.Data.SqlDbType.Int).Value = 1;

                //Checking to see if it worked
                try
                {
                    connection.Open();
                    SqlDataReader reads = command.ExecuteReader();

                    if (reads.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                connection.Close();
            }
           
            return success;
        }

        public List<User> GetAllEmployees()
        {
            List<User> employees = new List<User>();
            string sqlStatement = "SELECT * FROM dbo.Users WHERE ROLE = 2";

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                //Creates the new command
                SqlCommand command = new SqlCommand(sqlStatement, connection);
       
                //Checking to see if it worked
                try
                {
                    connection.Open();
                    SqlDataReader reads = command.ExecuteReader();

                    while(reads.Read())
                    {
                        employees.Add(new User { Id = (int)reads[0], UserName = (string)reads[1], Password = (string)reads[2], 
                            Email = (string)reads[3], FirstName = (string)reads[4], LastName = (string)reads[5] });
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                connection.Close();

            }

            return employees;
        }


        //Generates SHA256 Hash
        public string hashPass(string userPass)
        {

            string password = userPass;
            string hashedPass = Crypto.HashPassword(password);
            return hashedPass;
        }

    }
}
