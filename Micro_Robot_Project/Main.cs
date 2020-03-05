using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NationalInstruments.Visa;
using SpinnakerNET;
using SpinnakerNET.GenApi;

namespace Micro_Robot_Project
{
    public partial class Main : Form
    {
        private string lastResourceString = null;
        //Message session for USB1
        private MessageBasedSession mbSession1;
        //Message session for USB2
        private MessageBasedSession mbSession2;
        //Message session for USB3
        private MessageBasedSession mbSession3;
        //Message session for USB4
        private MessageBasedSession mbSession4;

        //USB Addresses that can be manually edited coe use with different devices or configurations
       // string USB1 = "USB::0x0A69::0x087F::L01000000439::INSTR";
        string USB1 = "USB::0x0957::0x0618::MY51070070::INSTR";
        string USB2 = "USB::0x0A69::0x087F::L01000000420::INSTR";
        string USB3 = "USB::0x0A69::0x087F::L01000000396::INSTR";
        string USB4 = "USB::0x0A69::0x087F::L01000000419::INSTR";


        public Main()
        {
            //initalize main form
            InitializeComponent();
        }
        private void Initialize_Communication_Click(object sender, EventArgs e)
        {
            // open all USB message based sessions upon for load
            using (var rmSession = new ResourceManager())
            {
                try
                {
                    mbSession1 = (MessageBasedSession)rmSession.Open(USB1);
                  //  mbSession2 = (MessageBasedSession)rmSession.Open(USB2);
                  //  mbSession3 = (MessageBasedSession)rmSession.Open(USB3);
                  //  mbSession4 = (MessageBasedSession)rmSession.Open(USB4);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("All USB Components Not Found");
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes all communication sessions
            if (mbSession1 != null)
            {
                mbSession1.Dispose();
            }
            if (mbSession2 != null)
            {
                mbSession2.Dispose();
            }
            if (mbSession2 != null)
            {
                mbSession3.Dispose();
            }
            if (mbSession4 != null)
            {
                mbSession4.Dispose();
            }
        }
        //This function pops up the Device Manager Form/ window when the USB_DEVICES button is clicked
        private void USB_DEVICES_Click(object sender, EventArgs e)
        {
            using (Device_Manager sr = new Device_Manager())
            {
                if (lastResourceString != null)
                {
                    sr.ResourceName = lastResourceString;
                }
                DialogResult result = sr.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    lastResourceString = sr.ResourceName;
                    Cursor.Current = Cursors.WaitCursor;
                    //using (var rmSession = new ResourceManager())
                    //{
                    //    try
                    //    {
                    //        mbSession1 = (MessageBasedSession)rmSession.Open(sr.ResourceName);

                    //    }
                    //    catch (InvalidCastException)
                    //    {
                    //        MessageBox.Show("Resource selected must be a message-based session");
                    //    }
                    //    catch (Exception exp)
                    //    {
                    //        MessageBox.Show(exp.Message);
                    //    }
                    //    finally
                    //    {
                    //        Cursor.Current = Cursors.Default;
                    //    }
                    //}
                }
            }
        }

        private void Leftbutton_Click(object sender, EventArgs e)
        {
            string textToWrite = "DISP BEEP";
            if (mbSession2 == null)
            {
                MessageBox.Show("Could Not Write to USB Port. Please Initalize Communication");
            }
            else
            {
                mbSession2.RawIO.Write(textToWrite);
            }
        }

        private void Down_button_Click(object sender, EventArgs e)
        {
            string textToWrite = "DISP BEEP";
            if (mbSession4 == null)
            {
                MessageBox.Show("Could Not Write to USB Port. Please Initalize Communication");
            }
            else
            {
                mbSession4.RawIO.Write(textToWrite);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
                string textToWrite = "DISP BEEP";
                if (mbSession3 == null)
                {
                    MessageBox.Show("Could Not Write to USB Port. Please Initalize Communication");
                }
                else
                {
                    mbSession3.RawIO.Write(textToWrite);
                }
        }

        private void UpButton_MouseDown(object sender, MouseEventArgs e)
        {

            string textToWrite = "DISP OFF";

            if (mbSession1 == null)
            {
                MessageBox.Show("Could Not Write to USB Port. Please Initalize Communication");
            }
            else
            {
                mbSession1.RawIO.Write(textToWrite);
            }
        }

        private void UpButton_MouseUp(object sender, MouseEventArgs e)
        {
            string textToWrite = "DISP ON";
            mbSession1.RawIO.Write(textToWrite);
        }

        private void CenterButton_MouseDown(object sender, MouseEventArgs e)
        {
            string textToWrite = "DISP OFF";
            if (mbSession1 == null || mbSession2 == null || mbSession3 == null || mbSession4 == null)
            {
                MessageBox.Show("Could Not Write to At Least One USB Port. Please Initalize Communication");
            }
            else
            {
                mbSession1.RawIO.Write(textToWrite);
                mbSession2.RawIO.Write(textToWrite);
                mbSession3.RawIO.Write(textToWrite);
                mbSession4.RawIO.Write(textToWrite);
            }
        }

        private void CenterButton_MouseUp(object sender, MouseEventArgs e)
        {
            string textToWrite = "DISP ON";
            mbSession1.RawIO.Write(textToWrite);
            mbSession2.RawIO.Write(textToWrite);
            mbSession3.RawIO.Write(textToWrite);
            mbSession4.RawIO.Write(textToWrite);
        }

        private void UpLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            string textToWrite = "DISP OFF";

            if (mbSession1 == null || mbSession2 == null)
            {
                MessageBox.Show("Could Not Write to USB Port. Please Initalize Communication");
            }
            else
            {
                mbSession1.RawIO.Write(textToWrite);
                mbSession2.RawIO.Write(textToWrite);
            }
        }

        private void UpLeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            string textToWrite = "DISP ON";
            mbSession1.RawIO.Write(textToWrite);
            mbSession2.RawIO.Write(textToWrite);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void UpRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            string textToWrite = "DISP OFF";

            if (mbSession1 == null || mbSession3 == null)
            {
                MessageBox.Show("Could Not Write to USB Port. Please Initalize Communication");
            }
            else
            {
                mbSession1.RawIO.Write(textToWrite);
                mbSession3.RawIO.Write(textToWrite);
            }
        }

        private void UpRightButton_MouseUp(object sender, MouseEventArgs e)
        {
            string textToWrite = "DISP ON";
            mbSession1.RawIO.Write(textToWrite);
            mbSession3.RawIO.Write(textToWrite);
        }
    }
}
