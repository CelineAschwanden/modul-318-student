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
        private StationBoardRoot stationBoard = new StationBoardRoot();
        private ITransport transport = new Transport();
        private bool selectedFromList = false; //for prevention of clearing text when selecting a suggestion

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toMain(sender, e);
        }

        private void toMain(object sender, EventArgs e)
        {
            panelMain.BringToFront();
        }

        private void toConnectionSearch(object sender, EventArgs e)
        {
            panelConnectionSearch.BringToFront();
        }

        //Sets title, fills table with data and then shows the Connections page
        private void toConnections(object sender, EventArgs e)
        {
            if (comboBoxVon.Text != "" && comboBoxBis.Text != "" && (radioButtonAb.Checked || radioButtonAn.Checked)) 
            {
                tableConnections.Rows.Clear();
                labelFromTo.Text = "Von " + comboBoxVon.Text + " bis " + comboBoxBis.Text;
                string date = datePicker.Value.ToString("yyyy-MM-dd");
                string time = timePicker.Value.ToString("HH:mm");
                string isArrivalTime = "0";
                if(radioButtonAn.Checked)
                    isArrivalTime = "1";
                connectionList = transport.GetConnections(comboBoxVon.Text, comboBoxBis.Text, date, time, isArrivalTime).ConnectionList;

                foreach (Connection c in connectionList) 
                {
                    string TimeFrom = DateTime.Parse(c.From.Departure).ToString("HH:mm");
                    string TimeTo = DateTime.Parse(c.To.Arrival).ToString("HH:mm");
                    tableConnections.Rows.Add(TimeFrom + " - " + TimeTo, c.From.Station.Name + " - " + c.To.Station.Name, c.From.Platform);
                }
                panelConnections.BringToFront();
            }
            else
            {
                MessageBox.Show("Bitte fülle alle Felder aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toBoardSearch(object sender, EventArgs e)
        {
            panelBoardSearch.BringToFront();
        }

        //Sets title, fills table with data and shows the found stationboard
        private void toStationBoard(object sender, EventArgs e)
        {
            if(comboBoxStation.Text != "")
            {
                labelStationBoardName.Text = comboBoxStation.Text;
                tableStationBoard.Rows.Clear();
                stationBoard = transport.GetStationBoard(comboBoxStation.Text);
                
                foreach (StationBoard sb in stationBoard.Entries)
                {
                    tableStationBoard.Rows.Add(sb.Stop.Departure.ToString("HH:mm"), sb.Number, sb.To);
                }
                panelStationBoard.BringToFront();
            }
            else
            {
                MessageBox.Show("Bitte gebe eine Station an!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toMap(object sender, EventArgs e)
        {
            //to be done
        }

        private void OnSelectFromList(object sender, EventArgs e)
        {
            selectedFromList = true;
        }

        //Fill ComboBox with suggestions each time the text is changed
        private void OnWriteFromTo(object sender, EventArgs e)
        {
            ComboBox currentComboBox;
            if (ActiveControl == comboBoxVon)
                currentComboBox = comboBoxVon;
            else if (ActiveControl == comboBoxBis)
                currentComboBox = comboBoxBis;
            else
                return;

            //prevent from clearing on select
            if (selectedFromList == false)
                currentComboBox.Items.Clear();
            else
                selectedFromList = false;


            List<string> suggestionList = new List<string>();
            foreach (Station s in transport.GetStations(currentComboBox.Text).StationList)
            {
                if (suggestionList.Count < 7)
                {
                    if (s.Name.StartsWith(currentComboBox.Text))
                        suggestionList.Add(s.Name);
                }
                else
                    break;
            }
            currentComboBox.Items.AddRange(suggestionList.ToArray());

            //prevent cursor from beeing set behind the first letter
            currentComboBox.SelectionStart = currentComboBox.Text.Length;
            currentComboBox.SelectionLength = 0;
        }
    }
}
