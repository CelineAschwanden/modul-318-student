using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace MyTransportApp
{
    public partial class FormMain : Form
    {
        private List<Connection> connectionList = new List<Connection>();
        private ITransport transport = new Transport();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelMain.BringToFront();
        }

        private void toMain(object sender, EventArgs e)
        {
            panelMain.BringToFront();
        }

        private void toSearch(object sender, EventArgs e)
        {
            panelSearch.BringToFront();
        }

        private void toConnections(object sender, EventArgs e)
        {
            if (textBoxVon.Text != "" && textBoxBis.Text != "" && (radioButtonAb.Checked || radioButtonAn.Checked)) 
            {
                connectionList = transport.GetConnections(textBoxVon.Text, textBoxBis.Text).ConnectionList;
                labelFromTo.Text = "Von " + textBoxVon.Text + " bis " + textBoxBis.Text;

                

                foreach (Connection c in connectionList) 
                {
                    string TimeFrom = DateTime.Parse(c.From.Departure).ToString("HH:mm");
                    string TimeTo = DateTime.Parse(c.To.Arrival).ToString("HH:mm");
                    tableConnections.Rows.Add(TimeFrom + " - " + TimeTo, "", c.From.Platform);
                }
                panelConnections.BringToFront();
            }
            else
            {
                MessageBox.Show("Bitte fülle alle Felder aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void toMap(object sender, EventArgs e)
        {

        }
    }
}
