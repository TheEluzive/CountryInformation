using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    textBoxArea.Text = item.Area.ToString();
                    textBoxPopulation.Text = item.Population.ToString();
                    textBoxRegion.Text = item.Region;
                    found = true;
                    break;

                }
            }
            if (found == false) MessageBox.Show("Страна не была найдена");
        }
    }
}
