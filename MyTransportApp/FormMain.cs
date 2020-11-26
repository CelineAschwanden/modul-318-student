using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class FormMain : Form
    {
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
            panelConnections.BringToFront();
        }

        private void toMap(object sender, EventArgs e)
        {

        }
    }
}
