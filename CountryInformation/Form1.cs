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
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
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
        }


       
        

        private async void Form1_Load(object sender, EventArgs e)
        {
           string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1eluz\source\repos\CountryInformation\CountryInformation\Database1.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT Countries.Name, Countries.Alpha3Code,  Cities.Name as Capital, Countries.Area, Countries.Population, Regions.Name as Region from Countries INNER JOIN Cities ON Countries.Capital = Cities.Id INNER JOIN Regions ON Countries.Region = Regions.Id ", sqlConnection);

            List<string[]> data = new List<string[]>();
            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = sqlDataReader[0].ToString();
                    data[data.Count - 1][1] = sqlDataReader[1].ToString();
                    data[data.Count - 1][2] = sqlDataReader[2].ToString();
                    data[data.Count - 1][3] = sqlDataReader[3].ToString();
                    data[data.Count - 1][4] = sqlDataReader[4].ToString();
                    data[data.Count - 1][5] = sqlDataReader[5].ToString();
                    
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
                if (sqlDataReader != null)
                    sqlDataReader.Close();
            }
        }

        private void TabPageDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}
