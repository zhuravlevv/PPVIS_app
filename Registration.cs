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
    public partial class Registration : Form
    {

        private String path = "../../Logins.txt";
        public Registration()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String newLogin = textBox1.Text.ToString();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path, true, System.Text.Encoding.Default);
            sw.WriteLine(newLogin);
            textBox1.Text = "";
            MessageBox.Show(
                "Вы успешно зарегистрировались",
                "Уведомление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            sw.Close();
            this.Close();
        }

    }
}
