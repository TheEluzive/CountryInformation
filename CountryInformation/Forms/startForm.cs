using System;
using System.Windows.Forms;

namespace CountryInformation
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        public void MainForm()
        {

            Form mainForm = new Form1();// dispose?
            Form1.PathToDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + textBoxPath.Text + ";Integrated Security = True";
            mainForm.ShowDialog();
        }

        private void ButtonSetPathToDB_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(MainForm).Start();

        }
    }
}
