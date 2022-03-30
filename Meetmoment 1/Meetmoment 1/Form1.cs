using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meetmoment_1
{
    public partial class Form1 : Form
    {
        int vraagnummer = 1;

        string antwoord1 = "";
        string antwoord2 = "";
        string antwoord3 = "";
        string antwoord4 = "";
        string antwoord5 = "";
        string antwoord6 = "";
        string antwoord7 = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void verder_Click(object sender, EventArgs e)
        {
            vraagnummer++;

            if (vraagnummer == 1)
            {
                BeoordelingspuntLabel.Text = "klantgericht";
            }
            if (vraagnummer == 2)
            {
                BeoordelingspuntLabel.Text = "proces";
                antwoord1 = beoordelingAntwoord.Text;
            }
            if (vraagnummer == 3)
            {
                BeoordelingspuntLabel.Text = "planning";
                antwoord2 = beoordelingAntwoord.Text;
            }
            if (vraagnummer == 4)
            {
                BeoordelingspuntLabel.Text = "standup";
                antwoord3 = beoordelingAntwoord.Text;
            }
            if (vraagnummer == 5)
            {
                BeoordelingspuntLabel.Text = "beroepscompetentie";
                antwoord4 = beoordelingAntwoord.Text;
            }
            if (vraagnummer == 6)
            {
                BeoordelingspuntLabel.Text = "samenwerking";
                antwoord5 = beoordelingAntwoord.Text;
            }
            if (vraagnummer == 7)
            {
                BeoordelingspuntLabel.Text = "beroepshouding";
                antwoord6 = beoordelingAntwoord.Text;
            }
            if (vraagnummer == 8)
            {
                BeoordelingspuntLabel.Visible = false;
                beoordelingAntwoord.Visible = false;
                opslaanknop.Visible = true;
                verder.Visible = false;
                antwoord7 = beoordelingAntwoord.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void terug_Click(object sender, EventArgs e)
        {
            vraagnummer--;

            if (vraagnummer == 1)
            {
                BeoordelingspuntLabel.Text = "klantgericht";
            }
            if (vraagnummer == 2)
            {
                BeoordelingspuntLabel.Text = "proces";
            }
            if (vraagnummer == 3)
            {
                BeoordelingspuntLabel.Text = "planning";
            }
            if (vraagnummer == 4)
            {
                BeoordelingspuntLabel.Text = "standup";
            }
            if (vraagnummer == 5)
            {
                BeoordelingspuntLabel.Text = "beroepscompetentie";
            }
            if (vraagnummer == 6)
            {
                BeoordelingspuntLabel.Text = "samenwerking";
            }
            if (vraagnummer == 7)
            {
                BeoordelingspuntLabel.Text = "beroepshouding";
                BeoordelingspuntLabel.Visible = true;
                beoordelingAntwoord.Visible = true;
                opslaanknop.Visible = false;
                verder.Visible = true;
            }
            if (vraagnummer == 8)
            {
                BeoordelingspuntLabel.Visible = false;
                beoordelingAntwoord.Visible = false;
                opslaanknop.Visible = true;
                verder.Visible = false;
            }
        }

        private void vlak_Paint(object sender, PaintEventArgs e)
        {

        }


        private void opslaanknop_Click(object sender, EventArgs e)
        {
            gegevens gegevens = new gegevens()
            {
                klantgericht = antwoord1,
                proces = antwoord2,
                planning = antwoord3,
                standup = antwoord4,
                beroepscompententie = antwoord5,
                samenwerking = antwoord6,
                beroepshouding = antwoord7,
            };
            
            string strResultJson = Newtonsoft.Json.JsonConvert.SerializeObject(gegevens);
            System.IO.File.WriteAllText(@"gegevens.json", strResultJson);
            MessageBox.Show("opgeslaagd");
            

        }
    }
}
