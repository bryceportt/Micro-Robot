using System;
using System.Windows.Forms;
using NationalInstruments.Visa;
using SpinnakerNET;
using SpinnakerNET.GenApi;

namespace Micro_Robot_Project
{
    public partial class Device_Manager : Form
    {
        public Device_Manager()
        {
            InitializeComponent();
        }

        public string ResourceName { get; internal set; }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            // This example uses an instance of the NationalInstruments.Visa.ResourceManager class to find resources on the system.
            // Alternatively, static methods provided by the Ivi.Visa.ResourceManager class may be used when an application
            // requires additional VISA .NET implementations.
            using (var rmSession = new ResourceManager())
            {
                var resources = rmSession.Find("(USB)?*");
                foreach (string s in resources)
                {
                    availableResourcesListBox.Items.Add(s);
                    
                }
            }
        }

        private void Left_Coil_Click(object sender, EventArgs e)
        {
            string selectedString = (string)availableResourcesListBox.SelectedItem;
            ResourceName = selectedString;
            this.DialogResult = DialogResult.OK;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Right_Coil_Click(object sender, EventArgs e)
        {
            string selectedString = (string)availableResourcesListBox.SelectedItem;
            ResourceName = selectedString;
            this.DialogResult = DialogResult.OK;
        }
    }
}
