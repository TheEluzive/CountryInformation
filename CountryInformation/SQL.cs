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

        public string connectionToDBinner;

        public string returnId;
        public SQL(string connectionToDB)
        {
            sqlConnection = new SqlConnection(connectionToDB); 
            sqlDataReader = null;
            connectionToDBinner = connectionToDB;
        }

       
        
        public void setSqlCommand(string command)
        {
            sqlCommand = new SqlCommand(command, sqlConnection);
        }

        public void addCommandParameters<T>(string paramName, T value)
        {
            sqlCommand.Parameters.AddWithValue(paramName, value);
        }

        public async Task<int> getEqualsByField<T>(string columnResult, string table, string column, T value )
        {
            SqlConnection sqlConnectionLocal = new SqlConnection(connectionToDBinner);
            SqlDataReader sqlDataReaderLocal = null;
            await sqlConnectionLocal.OpenAsync();
            string sqlCommandLocal = "SELECT " + columnResult + " from " + table + " WHERE " + column +"='" + value+"'";
            SqlCommand sqlCommand2 = new SqlCommand(sqlCommandLocal, sqlConnectionLocal);
            
            try
            {
                sqlDataReaderLocal = await sqlCommand2.ExecuteReaderAsync();                
                while (await sqlDataReaderLocal.ReadAsync())
                {
                    return Convert.ToInt32(sqlDataReaderLocal[0]);
                }
            }
            catch//??
            {                
                return 0;
            }
            finally
            {
                sqlConnectionLocal.Close();
            }
            return 0;

        }

        public async Task<string> simpleInsert(string command)
        {
            SqlConnection sqlConnectionLocal = new SqlConnection(connectionToDBinner);            
            await sqlConnectionLocal.OpenAsync();
            SqlCommand sqlCommandLocal = new SqlCommand(command, sqlConnectionLocal);

            try
            {
                await sqlCommandLocal.ExecuteNonQueryAsync();
                return "Ok";
            }
            catch(Exception ex)
            {
                return ex.Message.ToString();
            }
            finally
            {
                sqlConnectionLocal.Close();
            }
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
