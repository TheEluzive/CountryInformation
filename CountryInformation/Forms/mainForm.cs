using CountryInformation.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CountryInformation
{
    public partial class Form1 : Form
    {
        public static string PathToDB { get; set; }
        private SQL sql;
        private HighLvlSQL highLvlSQL;
        public Form1()
        {
            InitializeComponent();
        }



        public async void FillDataGrid() //заполнение таблицы во вкладке DataBase
        {
            await sql.OpenAsync();


            string sqlCommand = "SELECT Countries.Name, Countries.Alpha3Code,  Cities.Name as Capital, Countries.Area, Countries.Population, Regions.Name as Region from Countries INNER JOIN Cities ON Countries.Capital = Cities.Id INNER JOIN Regions ON Countries.Region = Regions.Id ";
            sql.SetSqlCommand(sqlCommand);

            List<string[]> data = new List<string[]>();
            try 
            {
                sql.SqlDataReader = await sql.ExecuteReaderAsync();
                while (await sql.SqlDataReader.ReadAsync())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = sql.SqlDataReader[0].ToString();
                    data[data.Count - 1][1] = sql.SqlDataReader[1].ToString();
                    data[data.Count - 1][2] = sql.SqlDataReader[2].ToString();
                    data[data.Count - 1][3] = sql.SqlDataReader[3].ToString();
                    data[data.Count - 1][4] = sql.SqlDataReader[4].ToString();
                    data[data.Count - 1][5] = sql.SqlDataReader[5].ToString();

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
                sql.SqlConnection.Close();
            }
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (var item in DataGetter.GetData())
            {
                if (textBoxSearchCountry.Text == item.Name)
                {
                    textBoxCountryNameResult.Text = item.Name;
                    textBoxCapital.Text = item.Capital;
                    textBoxAlpha3Code.Text = item.Alpha3Code;
                    textBoxArea.Text = item.Area.ToString();
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

                await highLvlSQL.SaveDataInDB(textBoxCountryNameResult.Text, textBoxAlpha3Code.Text, textBoxCapital.Text,
                    textBoxArea.Text, textBoxPopulation.Text, textBoxRegion.Text); //сохранение найденных полей в базу данных
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                FillDataGrid();


            }

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            sql = new SQL(PathToDB);
            FillDataGrid();
            highLvlSQL = new HighLvlSQL(sql);
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }



    }
}
