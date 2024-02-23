using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.Sqlite;

namespace Pan
{
    public class PansDataBase
    {
        private void PansCreate()
        {
            using var connection = new SqliteConnection("Data source = Pans.db");
            connection.Open();
            string createPansTableQuery = @"
                CREATE TABLE IF NOT EXISTS pans (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    producer_id INTEGER NOT NULL,
                    name TEXT NOT NULL,
                    price TEXT NOT NULL 
            );";
            

            var command = connection.CreateCommand();
            command.CommandText = createPansTableQuery;
            command.ExecuteNonQuery();

        }
        private void ProducerCreate() 
        {
            using var connection = new SqliteConnection("Data source = producer.db");
            connection.Open();
            string createProducerTable = @"
                CREATE TABLE IF NOT EXISTS producer (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                company TEXT NOT NULL
            );";
            var command = connection.CreateCommand();
            command.CommandText = createProducerTable;
            command.ExecuteNonQuery();
        }
        public void FullConnection() 
        {
            PansCreate();
            ProducerCreate();
        }
    };
}
