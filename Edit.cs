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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            textBox1.Text = dataStruct.selectedNotation.getSurname();
            textBox2.Text = dataStruct.selectedNotation.getNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notation notation = dataStruct.selectedNotation;
            notation.setSurname(textBox1.Text);
            notation.setNumber(textBox2.Text);
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
