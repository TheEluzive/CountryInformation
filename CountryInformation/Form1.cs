using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CountryInformation.Model;

namespace CountryInformation
{
    public partial class Form1 : Form
    {
        static string pathToDB= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1eluz\source\repos\CountryInformation\CountryInformation\Database1.mdf;Integrated Security = True";
        SQL sql = new SQL(pathToDB);
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<int> insertOrUpdateDB(string sqlCommand)
        {
            sql.setSqlCommand(sqlCommand);
            string insertResult = "";
            try
            {
                int returnedId = await sql.getEqualsByField("Id", "Cities", "Name", textBoxCapital.Text);
                if (returnedId == 0)
                {
                    insertResult = (await sql.simpleInsert("INSERT INTO Cities values('" + textBoxCapital.Text + "')")).ToString();
                    if (!insertResult.Equals("Ok")) MessageBox.Show(insertResult, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sql.addCommandParameters("Capital", await sql.getEqualsByField("Id", "Cities", "Name", textBoxCapital.Text));
                }
                else
                {
                    sql.addCommandParameters("Capital", returnedId);
                }

                returnedId = await sql.getEqualsByField("Id", "Regions", "Name", textBoxRegion.Text);
                if (returnedId == 0)
                {
                    insertResult = (await sql.simpleInsert("INSERT INTO Regions values('" + textBoxRegion.Text + "')")).ToString();
                    if (!insertResult.Equals("Ok")) MessageBox.Show(insertResult, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sql.addCommandParameters("Region", await sql.getEqualsByField("Id","Regions", "Name", textBoxRegion.Text));
                }
                else
                {
                    sql.addCommandParameters("Region", returnedId);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                sql.addCommandParameters("Name", textBoxCountryNameResult.Text);
                sql.addCommandParameters("Alpha3Code", textBoxAlpha3Code.Text);


                sql.addCommandParameters("Area", float.Parse(textBoxArea.Text));
                sql.addCommandParameters("Population", Convert.ToInt32(textBoxPopulation.Text));



                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                await sql.sqlCommand.ExecuteNonQueryAsync();
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                sql.sqlConnection.Close();
            }
        }

        public async void fillDataGrid()
        {
           
            await sql.sqlConnection.OpenAsync();

            string sqlCommand = "SELECT Countries.Name, Countries.Alpha3Code,  Cities.Name as Capital, Countries.Area, Countries.Population, Regions.Name as Region from Countries INNER JOIN Cities ON Countries.Capital = Cities.Id INNER JOIN Regions ON Countries.Region = Regions.Id ";
            sql.setSqlCommand(sqlCommand);

            List<string[]> data = new List<string[]>();
            try //заполнение таблицы во вкладке DataBase
            {
                sql.sqlDataReader = await sql.executeSqlCommand();
                while (await sql.sqlDataReader.ReadAsync())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = sql.sqlDataReader[0].ToString();
                    data[data.Count - 1][1] = sql.sqlDataReader[1].ToString();
                    data[data.Count - 1][2] = sql.sqlDataReader[2].ToString();
                    data[data.Count - 1][3] = sql.sqlDataReader[3].ToString();
                    data[data.Count - 1][4] = sql.sqlDataReader[4].ToString();
                    data[data.Count - 1][5] = sql.sqlDataReader[5].ToString();

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.sqlConnection.Close();
            }
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var item in DataGetter.getData())
            {
               if (textBoxSearchCountry.Text == item.Name)
                {
                    textBoxCountryNameResult.Text = item.Name;
                    textBoxCapital.Text = item.Capital;
                    textBoxAlpha3Code.Text = item.Alpha3Code;
                    textBoxArea.Text = (item.Area/1000).ToString();
                    textBoxPopulation.Text = item.Population.ToString();
                    textBoxRegion.Text = item.Region;
                    found = true;
                    break;

                }
            }
            if (found == false) MessageBox.Show("Страна не была найдена");
            else
                if (MessageBox.Show("Сохранить в базу данных информацию?", "Страна найдена", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                
                await sql.sqlConnection.OpenAsync();
                string sqlCommand;
                int returnedId = await sql.getEqualsByField("Id", "Countries", "Alpha3Code", textBoxAlpha3Code.Text.ToString());
                if (returnedId == 0)
                    sqlCommand = "INSERT INTO Countries(Name, Alpha3Code, Capital, Area, Population, Region) Values(@Name, @Alpha3Code, @Capital, @Area, @Population, @Region)";
                else sqlCommand = "UPDATE Countries SET Name = @Name, Alpha3Code = @Alpha3Code, Capital = @Capital, Area = @Area, Population = @Population, Region = @Region WHERE Alpha3Code = '"+ textBoxAlpha3Code.Text.ToString()+"'";
                await insertOrUpdateDB(sqlCommand);

                fillDataGrid();

            }
            
        }


       
        

        private async void Form1_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        
    }
}
