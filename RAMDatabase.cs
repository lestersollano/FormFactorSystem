using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using System.Data;

namespace FormFactorSystem
{
    internal class RAMDatabase
    {
        public string connectionString = "Data Source=FORMFACTOR.db";

        public void Initialize()
        {
            CreateTable();
        }

        public void CreateTable()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "CREATE TABLE IF NOT EXISTS RAM (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Capacity INTEGER, Ghz INTEGER, Version TEXT, Quantity INTEGER, Price DECIMAL, Sold INTEGER DEFAULT 0, Reserved INTEGER DEFAULT 0)";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DropTable()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "DROP TABLE IF EXISTS RAM";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Add(string name, int capacity, int ghz, string version, int quantity, double price)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO RAM (Name, Capacity, Ghz, Version, Quantity, Price) VALUES (@name, @capacity, @ghz, @version, @quantity, @price)";
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@ghz", ghz);
                    command.Parameters.AddWithValue("@version", version);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(int id, string name, int capacity, int ghz, int version, int quantity, double price)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "UPDATE RAM SET Name = @name, Capacity = @capacity, Ghz = @ghz, Version = @version, Quantity = @quantity WHERE Id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@ghz", ghz);
                    command.Parameters.AddWithValue("@version", version);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "DELETE FROM RAM WHERE Id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetTable()
        {
            DataTable RAMData = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {

                using (SqliteCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "SELECT * FROM RAM";
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        RAMData.Load(reader);
                        return RAMData;
                    }
                }
            }
        }
    }
}
