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

        public async Task<int> getIdByField<T>(string table, string column, T value )
        {
            SqlConnection sqlConnectionLocal = new SqlConnection(connectionToDBinner);
            SqlDataReader sqlDataReaderLocal = null;
            await sqlConnectionLocal.OpenAsync();
            string sqlCommandLocal = "SELECT Id from " + table + " WHERE " + column +"='" + value+"'";
            SqlCommand sqlCommand2 = new SqlCommand(sqlCommandLocal, sqlConnectionLocal);
            
            try
            {
                sqlDataReaderLocal = await sqlCommand2.ExecuteReaderAsync();
                //int[] result = new int[2];
                while (await sqlDataReaderLocal.ReadAsync())
                {
                    return Convert.ToInt32(sqlDataReaderLocal[0]);
                }
            }
            catch
            {
                returnId = "10";
                return 0;
            }
            finally
            {
                
            }
            return 0;

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
