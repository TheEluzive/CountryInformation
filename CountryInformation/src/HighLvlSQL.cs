using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryInformation
{
    class HighLvlSQL
    {
        private readonly SQL sql;
        public HighLvlSQL(SQL sql)
        {
            this.sql = sql;
        }
        public async Task<int> InsertOrUpdateDB(string sqlCommand, string name, string alpha3Code, string capital, float area, string population, string region)
        {
            await sql.OpenAsync();
            sql.SetSqlCommand(sqlCommand);
            string insertResult;
            try
            {
                int returnedId = await sql.GetEqualsByField("Id", "Cities", "Name", capital);
                if (returnedId == 0)
                {
                    insertResult = (await sql.SimpleInsert("INSERT INTO Cities values('" + capital + "')")).ToString();
                    if (!insertResult.Equals("Ok")) MessageBox.Show(insertResult, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sql.AddCommandParameters("Capital", await sql.GetEqualsByField("Id", "Cities", "Name", capital));
                }
                else
                {
                    sql.AddCommandParameters("Capital", returnedId);
                }

                returnedId = await sql.GetEqualsByField("Id", "Regions", "Name", region);
                if (returnedId == 0)
                {
                    insertResult = (await sql.SimpleInsert("INSERT INTO Regions values('" + region + "')")).ToString();
                    if (!insertResult.Equals("Ok")) MessageBox.Show(insertResult, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sql.AddCommandParameters("Region", await sql.GetEqualsByField("Id", "Regions", "Name", region));
                }
                else
                {
                    sql.AddCommandParameters("Region", returnedId);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                sql.AddCommandParameters("Name", name);
                sql.AddCommandParameters("Alpha3Code", alpha3Code);


                sql.AddCommandParameters("Area", area);
                sql.AddCommandParameters("Population", Convert.ToInt32(population));



                await sql.OpenAsync();             
                await sql.SqlCommand.ExecuteNonQueryAsync();
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                sql.SqlConnection.Close();
            }
        }

        public async Task<int> SaveDataInDB(string name, string alpha3Code, string capital, float area, string population, string region)
        {
            await sql.SqlConnection.OpenAsync();
            string sqlCommand;
            int returnedId = await sql.GetEqualsByField("Id", "Countries", "Alpha3Code", alpha3Code);
            if (returnedId == 0)
                sqlCommand = "INSERT INTO Countries(Name, Alpha3Code, Capital, Area, Population, Region) Values(@Name, @Alpha3Code, @Capital, @Area, @Population, @Region)";
            else sqlCommand = "UPDATE Countries SET Name = @Name, Alpha3Code = @Alpha3Code, Capital = @Capital, Area = @Area, Population = @Population, Region = @Region WHERE Alpha3Code = '" + alpha3Code + "'";
            await InsertOrUpdateDB(sqlCommand, name,  alpha3Code,  capital,  area, population, region);
            return 0;

        }

       
    }
}
