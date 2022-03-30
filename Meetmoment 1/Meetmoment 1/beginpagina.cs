using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Meetmoment_1
{
    public partial class beginpagina : Form
    {
        public beginpagina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();

            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultaten resultaten = new resultaten();

            resultaten.ShowDialog();
        }

        private void beginpagina_Load(object sender, EventArgs e)
        {
            
        }
    }
}