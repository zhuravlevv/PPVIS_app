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
    struct dataStruct {
        public static List<Notation> notations = new List<Notation>();
        public static Notation selectedNotation = null;
    }
    public partial class Main : Form
    {
        private Edit edit;
        private Authorithation authorithation;
        
        public Main()
        {
            authorithation = new Authorithation();
            edit = new Edit();
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            authorithation.ShowDialog();
        }

        private void createDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notation not1 = new Notation("Ignatsiuc", "+375291111111");
            Notation not2 = new Notation("Dubina", "+375292222222");
            Notation not3 = new Notation("Zhuravlev", "+375293333333");

            dataStruct.notations.Clear();

            dataStruct.notations.Add(not1);
            dataStruct.notations.Add(not2);
            dataStruct.notations.Add(not3);

        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < dataStruct.notations.Count(); i++)
            {
                listBox1.Items.Add(dataStruct.notations[i]);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Notation selectedItem = (Notation) listBox1.SelectedItem;
            dataStruct.selectedNotation = selectedItem;
            edit.ShowDialog();
            listBox1.Items.Clear();
            for(int i = 0; i < dataStruct.notations.Count(); i++)
            {
                listBox1.Items.Add(dataStruct.notations[i]);
            }
        }

    }
}
