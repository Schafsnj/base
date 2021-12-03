﻿using APPS_Web_APP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace APPS_Web_APP.Services
{
    public class TaskDAO
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=APPS-Project-Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Task> GetAllTasks()
        {
            List<Task> tasks = new List<Task>();
            string sqlStatement = "SELECT * FROM dbo.Tasks";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Creates the new command
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //Checking to see if it worked
                try
                {
                    connection.Open();
                    SqlDataReader reads = command.ExecuteReader();

                    while (reads.Read())
                    {
                        tasks.Add(new Task
                        {
                            Id = (int)reads[0],
                            TaskName = (string)reads[1],
                            TaskDesc = (string)reads[2],
                            Company = (string)reads[3],
                            Contact = (string)reads[4],
                            Email = (string)reads[5]
                        });
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                connection.Close();

            }

            return tasks;
        }

        public void AddTask(Task task)
        {

            string sqlStatement = "Insert into dbo.Tasks(TASKNAME, TASKDESC, COMPANY, CONTACT, EMAIL) values(@taskname, @taskdesc, @company, @contact, @email)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //Adding parameter
                command.Parameters.Add("@taskname", System.Data.SqlDbType.VarChar, 40).Value = task.TaskName;
                command.Parameters.Add("@taskdesc", System.Data.SqlDbType.VarChar, 100).Value = task.TaskName;
                command.Parameters.Add("@company", System.Data.SqlDbType.VarChar, 100).Value = task.Company;
                command.Parameters.Add("@contact", System.Data.SqlDbType.VarChar, 40).Value = task.Contact;
                command.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 40).Value = task.Email;

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

        public void DeleteTask(int Id)
        {

            string sqlStatement = "DELETE FROM dbo.Tasks WHERE Id = @Id";
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
    }


}
