using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Meetmoment_1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

            
        private void Form2_Load(object sender, EventArgs e)
        {
          
            var jsonObj = System.IO.File.ReadAllLines (@"C:\Users\kevin\source\repos\voortgangsmeting1\Meetmoment 1\Meetmoment 1\bin\Debug\netcoreapp3.1\gegevens.json")[0];
            //string jsonParsed = @jsonObj.ToString();
            System.Diagnostics.Debug.WriteLine($"testObj: {jsonObj}");

            gegevensInst jsonDes = JsonConvert.DeserializeObject<gegevensInst>(jsonObj);
           
           

            // listview item aanmaken
            var listViewItem = new ListViewItem(new string[] { jsonDes.Klantgericht, jsonDes.proces, jsonDes.planning, jsonDes.standup, jsonDes.beroepscompententie, jsonDes.beroepshouding, jsonDes.samenwerking });
            

            // listview item toevoegen aan de listview
            resultatenlistview.Items.Add(listViewItem);

        }
    }
}
