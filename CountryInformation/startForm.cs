using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryInformation
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        public void mainForm()
        {

            Form mainForm = new Form1();
            Form1.pathToDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + textBoxPath.Text + ";Integrated Security = True";
            mainForm.ShowDialog();
        }

        private void ButtonSetPathToDB_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(mainForm).Start();

            
            
        }
    }
}
