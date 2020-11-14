using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationV2
{
    public partial class Authorithation : Form
    {
        private String path = "../../Logins.txt";
        private bool userExists = false;
        private Registration registration;
        public Authorithation()
        {
            registration = new Registration();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            registration.ShowDialog();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(path, System.Text.Encoding.Default);
            string enteredLogin = textBox1.Text.ToString();
            string line;
            userExists = false;
            while ((line = sr.ReadLine()) != null)
            {
                if(line == enteredLogin)
                {
                    userExists = true;
                    break;
                }
            }
            if (userExists)
            {
                this.Close();
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show(
                    "Не верный логин!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            sr.Close();

        }

        private void Authorithation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!userExists)
            {
                Application.Exit();
            }
        }

        private void Authorithation_Load(object sender, EventArgs e)
        {

        }
    }
}
