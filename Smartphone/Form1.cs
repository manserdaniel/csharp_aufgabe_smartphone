using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone
{
    public partial class Form1 : Form
    {
        Smartphone mySmartphone = new Smartphone();
        public Form1()
        {
            InitializeComponent();
            mySmartphone.Apps1.Add(new App("Facebook", "1.1.0"));
            mySmartphone.Apps1.Add(new App("WhatsApp", "22.1.0"));
            mySmartphone.Apps1.Add(new Game("SpaceWar", "7.1.0", true));
            mySmartphone.Apps1.Add(new Game("Hayday", "1.1.0", false));
            mySmartphone.Apps1.Add(new Game("Skidoo", "1.1.0", true));
            cbFilter.DataSource = new List<string>() { typeof(App).Name, typeof(Game).Name };
            UpdateAppList();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var selectedApp = lboxApps.SelectedItem;

            mySmartphone.Apps1.Find(x => x.ToString().Equals(selectedApp.ToString())).StartApp();
            UpdateAppsStartet();
        }

        private void UpdateAppList()
        {
            lboxApps.DataSource = mySmartphone.Apps1.Where(x => x.GetType().Name == cbFilter.SelectedItem.ToString()).ToList();
        }

        private void UpdateAppsStartet()
        {
            lboxStartedApps.DataSource = mySmartphone.Apps1.Where(x => x.On == true).ToList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAppList();
        }

        private void lboxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedApp = lboxApps.SelectedItem as App;

            if(selectedApp != null)
            {
                btnStart.Text = "Start: " + selectedApp.Name;
            }
            else
            {
                MessageBox.Show("No valid App");
            }
        }
    }
}
