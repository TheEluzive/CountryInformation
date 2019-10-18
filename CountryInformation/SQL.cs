using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInformation
{
    class SQL
    {
        public SqlCommand sqlCommand { get; set; }
        public SqlConnection sqlConnection { get;}
        public SqlDataReader sqlDataReader { get; set; }

        public int returnId;
        public SQL(string connectionToDB)
        {
            sqlConnection = new SqlConnection(connectionToDB); 
            sqlDataReader = null;
        }

       
        
        public void setSqlCommand(string command)
        {
            sqlCommand = new SqlCommand(command, sqlConnection);
        }

        public void addCommandParameters<T>(string paramName, T value)
        {
            sqlCommand.Parameters.AddWithValue(paramName, value);
        }

        public async void getIdByField<T>(string table, string column, T value )
        {
            setSqlCommand("SELECT Id from @Table WHERE @column = @value");
            
            sqlCommand.Parameters.AddWithValue("Table", table);
            sqlCommand.Parameters.AddWithValue("column", column);
            sqlCommand.Parameters.AddWithValue("value", value);
            //addCommandParameters("table", table);
            //addCommandParameters("column", column);
            //addCommandParameters("value", value);
            sqlDataReader = await executeSqlCommand();
            sqlDataReader.ReadAsync();
            returnId = Convert.ToInt32(sqlDataReader);
           
        }


        public Task<SqlDataReader> executeSqlCommand()
        {
            return sqlCommand.ExecuteReaderAsync();
        }

        public void close()
        {
            if (sqlDataReader != null)
                sqlDataReader.Close();
        }
    }
}
