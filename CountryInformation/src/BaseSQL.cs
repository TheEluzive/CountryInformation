using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CountryInformation
{
    class SQL
    {
        public SqlCommand SqlCommand { get; set; }
        public SqlConnection SqlConnection { get; }
        public SqlDataReader SqlDataReader { get; set; }

        private string connectionToDBinner;


        public SQL(string connectionToDB)
        {
            SqlConnection = new SqlConnection(connectionToDB);
            SqlDataReader = null;
            connectionToDBinner = connectionToDB;
        }

        public void SetSqlCommand(string command) //установить запрос
        {
            SqlCommand = new SqlCommand(command, SqlConnection);
        }

        public void AddCommandParameters<T>(string paramName, T value)//добавление параметров в запрос
        {
            SqlCommand.Parameters.AddWithValue(paramName, value);
        }

        public async Task<int> GetEqualsByField<T>(string columnResult, string table, string column, T value)//поиск значения в одном столбце и возврат значения из другого, если не нашлось то возвращается 0
        {
            SqlConnection sqlConnectionLocal = new SqlConnection(connectionToDBinner);
            SqlDataReader sqlDataReaderLocal = null;
            await sqlConnectionLocal.OpenAsync();
            string sqlStrCommandLocal = "SELECT " + columnResult + " from " + table + " WHERE " + column + "='" + value + "'";
            SqlCommand sqlCommandLocal = new SqlCommand(sqlStrCommandLocal, sqlConnectionLocal);

            try
            {
                sqlDataReaderLocal = await sqlCommandLocal.ExecuteReaderAsync();
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
                sqlCommandLocal.Dispose();
                sqlDataReaderLocal.Close();

            }
            return 0;

        }

        public async Task<string> SimpleInsert(string command)
        {
            SqlConnection sqlConnectionLocal = new SqlConnection(connectionToDBinner);
            await sqlConnectionLocal.OpenAsync();
            SqlCommand sqlCommandLocal = new SqlCommand(command, sqlConnectionLocal);

            try
            {
                await sqlCommandLocal.ExecuteNonQueryAsync();
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            finally
            {
                sqlConnectionLocal.Close();
                sqlCommandLocal.Dispose();

            }
        }

        public Task<SqlDataReader> ExecuteReaderAsync()
        {
            return SqlCommand.ExecuteReaderAsync();
        }

        public async Task<int> OpenAsync()
        {
            if (SqlConnection.State != System.Data.ConnectionState.Open)
            {
                await SqlConnection.OpenAsync();
            }
            return 0;
        }


    }
}
