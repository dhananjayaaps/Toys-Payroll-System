using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace GrifindoToysPayrollSystem
{
    public class DatabaseManager
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Constructor
        public DatabaseManager()
        {
            Initialize();
        }

        // Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "toystore";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        // Open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Insert statement
        public bool Insert(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            return false;
        }

        // Update statement
        public bool Update(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            return false;
        }

        // Delete statement
        public bool Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            return false;
        }

        public Employee GetEmployeeDetails(string query)
        {
            Employee employee = null;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        employee = new Employee
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Salary = Convert.ToDecimal(reader["salary"]),
                            OTRate = Convert.ToDecimal(reader["ot_rate"]),
                            Allowance = Convert.ToDecimal(reader["allowance"])
                        };
                    }
                }
                this.CloseConnection();
            }
            return employee;
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            if (this.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                this.CloseConnection();
            }

            return dataTable;
        }

        public void ExecuteQuery(string query)
        {
            if(OpenConnection()){
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    CloseConnection();
          
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
