using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Meetmoment_1
{
    public partial class resultaten : Form
    {
        public resultaten()
        {
            InitializeComponent();
        }

        private void resultaten_Load(object sender, EventArgs e)
        {
            
            

            // rij aanmaken
            string[] row = { "O", "V", "G", "A", "B", "C" };
            
            // listview item aanmaken
            var listViewItem = new ListViewItem(row);

            // listview item toevoegen aan de listview
            UitslagenListView.Items.Add(listViewItem);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        



        }

        private void UitslagenListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
