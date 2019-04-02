using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Color
{
    public partial class Form1 : Form
    {
        private DateTime datatime;
        private string data;


        public Form1()
        {
            InitializeComponent();

            //--------- too hide app when run-----------
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            ShowInTaskbar = false; //------Remove from taskbar------- 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


            string[] ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);
            portBox.SelectedIndex = 0;
            disConn.Enabled = false;

        

            #region list
            listView1.Items[0].SubItems[0].Text = "0";
            listView1.Items[0].SubItems[1].Text = "Static";

            listView1.Items[1].SubItems[0].Text = "1";
            listView1.Items[1].SubItems[1].Text = "Blink";

            listView1.Items[2].SubItems[0].Text = "2";
            listView1.Items[2].SubItems[1].Text = "Breath";

            listView1.Items[3].SubItems[0].Text = "3";
            listView1.Items[3].SubItems[1].Text = "Color Wipe";

            listView1.Items[4].SubItems[0].Text = "4";
            listView1.Items[4].SubItems[1].Text = "Color Wipe Inverse";

            listView1.Items[5].SubItems[0].Text = "5";
            listView1.Items[5].SubItems[1].Text = "Color Wipe Reverse";

            listView1.Items[6].SubItems[0].Text = "6";
            listView1.Items[6].SubItems[1].Text = "Color Wipe Reverse Inverse";

            listView1.Items[7].SubItems[0].Text = "7";
            listView1.Items[7].SubItems[1].Text = "Color Wipe Random";

            listView1.Items[8].SubItems[0].Text = "8";
            listView1.Items[8].SubItems[1].Text = "Random Color";

            listView1.Items[9].SubItems[0].Text = "9";
            listView1.Items[9].SubItems[1].Text = "Single Dynamic";

            listView1.Items[10].SubItems[0].Text = "10";
            listView1.Items[10].SubItems[1].Text = "Multi Dynamic";

            listView1.Items[11].SubItems[0].Text = "11";
            listView1.Items[11].SubItems[1].Text = "Rainbow";

            listView1.Items[12].SubItems[0].Text = "12";
            listView1.Items[12].SubItems[1].Text = "Rainbow Cycle";

            listView1.Items[13].SubItems[0].Text = "13";
            listView1.Items[13].SubItems[1].Text = "Scan";

            listView1.Items[14].SubItems[0].Text = "14";
            listView1.Items[14].SubItems[1].Text = "Dual Scan";

            listView1.Items[15].SubItems[0].Text = "15";
            listView1.Items[15].SubItems[1].Text = "Fade";

            listView1.Items[16].SubItems[0].Text = "16";
            listView1.Items[16].SubItems[1].Text = "Theater Chase";

            listView1.Items[17].SubItems[0].Text = "17";
            listView1.Items[17].SubItems[1].Text = "Theater Chase Rainbow";

            listView1.Items[18].SubItems[0].Text = "18";
            listView1.Items[18].SubItems[1].Text = "Running Lights";

            listView1.Items[19].SubItems[0].Text = "19";
            listView1.Items[19].SubItems[1].Text = "Twinkle";

            listView1.Items[20].SubItems[0].Text = "20";
            listView1.Items[20].SubItems[1].Text = "Twinkle Random";

            listView1.Items[21].SubItems[0].Text = "21";
            listView1.Items[21].SubItems[1].Text = "Twinkle Fade";

            listView1.Items[22].SubItems[0].Text = "22";
            listView1.Items[22].SubItems[1].Text = "Twinkle Fade Random";

            listView1.Items[23].SubItems[0].Text = "23";
            listView1.Items[23].SubItems[1].Text = "Sparkle";

            listView1.Items[24].SubItems[0].Text = "24";
            listView1.Items[24].SubItems[1].Text = "Flash Sparkle";

            listView1.Items[25].SubItems[0].Text = "25";
            listView1.Items[25].SubItems[1].Text = "Hyper Sparkle";

            listView1.Items[26].SubItems[0].Text = "26";
            listView1.Items[26].SubItems[1].Text = "Strobe";

            listView1.Items[27].SubItems[0].Text = "27";
            listView1.Items[27].SubItems[1].Text = "Strobe Rainbow";

            listView1.Items[28].SubItems[0].Text = "28";
            listView1.Items[28].SubItems[1].Text = "Multi Strobe";

            listView1.Items[29].SubItems[0].Text = "29";
            listView1.Items[29].SubItems[1].Text = "Blink Rainbow";

            listView1.Items[30].SubItems[0].Text = "30";
            listView1.Items[30].SubItems[1].Text = "Chase White";

            listView1.Items[31].SubItems[0].Text = "31";
            listView1.Items[31].SubItems[1].Text = "Chase Color";

            listView1.Items[32].SubItems[0].Text = "32";
            listView1.Items[32].SubItems[1].Text = "Chase Random";

            listView1.Items[33].SubItems[0].Text = "33";
            listView1.Items[33].SubItems[1].Text = "Chase Rainbow";

            listView1.Items[34].SubItems[0].Text = "34";
            listView1.Items[34].SubItems[1].Text = "Chase Flash";

            listView1.Items[35].SubItems[0].Text = "35";
            listView1.Items[35].SubItems[1].Text = "Chase Flash Random";

            listView1.Items[36].SubItems[0].Text = "36";
            listView1.Items[36].SubItems[1].Text = "Chase Rainbow White";

            listView1.Items[37].SubItems[0].Text = "37";
            listView1.Items[37].SubItems[1].Text = "Chase Blackout";

            listView1.Items[38].SubItems[0].Text = "38";
            listView1.Items[38].SubItems[1].Text = "Chase Blackout Rainbow";

            listView1.Items[39].SubItems[0].Text = "39";
            listView1.Items[39].SubItems[1].Text = "Color Sweep Random";

            listView1.Items[40].SubItems[0].Text = "40";
            listView1.Items[40].SubItems[1].Text = "Running Color";

            listView1.Items[41].SubItems[0].Text = "41";
            listView1.Items[41].SubItems[1].Text = "Running Red Blue";

            listView1.Items[42].SubItems[0].Text = "42";
            listView1.Items[42].SubItems[1].Text = "Running Random";

            listView1.Items[43].SubItems[0].Text = "43";
            listView1.Items[43].SubItems[1].Text = "Larson Scanner";

            listView1.Items[44].SubItems[0].Text = "44";
            listView1.Items[44].SubItems[1].Text = "Comet";

            listView1.Items[45].SubItems[0].Text = "45";
            listView1.Items[45].SubItems[1].Text = "Fireworks";

            listView1.Items[46].SubItems[0].Text = "46";
            listView1.Items[46].SubItems[1].Text = "Fireworks Random";

            listView1.Items[47].SubItems[0].Text = "47";
            listView1.Items[47].SubItems[1].Text = "Merry Christmas";

            listView1.Items[48].SubItems[0].Text = "48";
            listView1.Items[48].SubItems[1].Text = "Fire Flicker";

            listView1.Items[49].SubItems[0].Text = "49";
            listView1.Items[49].SubItems[1].Text = "Fire Flicker (soft)";

            listView1.Items[50].SubItems[0].Text = "50";
            listView1.Items[50].SubItems[1].Text = "Fire Flicker (intense)";

            listView1.Items[51].SubItems[0].Text = "51";
            listView1.Items[51].SubItems[1].Text = "Circus Combustus";

            listView1.Items[52].SubItems[0].Text = "52";
            listView1.Items[52].SubItems[1].Text = "Halloween";

            listView1.Items[53].SubItems[0].Text = "53";
            listView1.Items[53].SubItems[1].Text = "Bicolor Chase";

            listView1.Items[54].SubItems[0].Text = "54";
            listView1.Items[54].SubItems[1].Text = "Tricolor Chase";

            listView1.Items[55].SubItems[0].Text = "55";
            listView1.Items[55].SubItems[1].Text = "ICU";

            #endregion

            
        }

        //-------------Conn_Click-----------------------------------------
        private void Conn_Click(object sender, EventArgs e)
        {

            Conn.Enabled = false;
            disConn.Enabled = true;
            serialPort1.DataReceived += serialPort1_data;
            try
            {
                serialPort1.PortName = portBox.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //----------------------------------------------------------------


        //------------------------------serialPort1_data----------------
        private void serialPort1_data(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(displaydata_event));
        }
        //--------------------------------------------------------------

        //---------------------displaydata_event------------------------
        private void displaydata_event(object sender, EventArgs e)
        {
            datatime = DateTime.Now;
            string time = datatime.Hour + ":" + datatime.Minute + ":" + datatime.Second;
            textBoxRead.AppendText(data);
            
        }
        //--------------------------------------------------------------

        //-----disConn_Click--------------------------------------------
        private void disConn_Click_1(object sender, EventArgs e)
        {
            Conn.Enabled = true;
            disConn.Enabled = false;

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------

        //-------------apply button for mods----------------------------
        private void Apply_Click(object sender, EventArgs e)
        {
      
            if (serialPort1.IsOpen)
            {
                try
                {
                    String text = textBoxSend.Text;
                    serialPort1.Write("m " + text);
                    textBoxSend.Clear();
                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //-------------------press enter event for mods-----------------
        private void enter(object sender, KeyEventArgs e)
        {
            textBoxSend.KeyDown += new KeyEventHandler(enter);
            if(e.KeyCode == Keys.Enter)
            {

                if (serialPort1.IsOpen)
                {
                    try
                    {
                        String text = textBoxSend.Text;
                        serialPort1.Write("m " + text);
                        textBoxSend.Clear();
                    }
                    catch (Exception er)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //--------------------------------------------------------------

       //----------------apply btuuon for speed-------------------------
        private void Applys_Click(object sender, EventArgs e)
        {


            if (serialPort1.IsOpen)
            {
                try
                {
                    String text = textBoxspeed.Text;
                    serialPort1.Write("s " + text);
                    textBoxspeed.Clear();
                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       //--------------------press enter event for speed---------------- 
        private void enters(object sender, KeyEventArgs e)
        {
            textBoxspeed.KeyDown += new KeyEventHandler(enter);
            if (e.KeyCode == Keys.Enter)
            {

                if (serialPort1.IsOpen)
                {
                    try
                    {
                        String text = textBoxspeed.Text;
                        serialPort1.Write("s " + text);
                        textBoxspeed.Clear();
                    }
                    catch (Exception er)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //-------------------------------------------------------------- 

        //------------to select item number in list---------------------
        private void select_item(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection items = this.listView1.SelectedItems;

            string NO = "";
            foreach (ListViewItem item in items)
            {
                NO = item.SubItems[0].Text;
            }

            // Output the price to TextBox1.
            textBoxSend.Text = NO;

        }
        //--------------------------------------------------------------

        //------------apply button for britness------------------------- 
        private void applyb_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                try
                {
                    String text = textBoxbri.Text;
                    serialPort1.Write("b " + text);
                    textBoxbri.Clear();
                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //----------------press enter event for britness----------------
        private void enterb(object sender, KeyEventArgs e)
        {
            textBoxspeed.KeyDown += new KeyEventHandler(enter);
            if (e.KeyCode == Keys.Enter)
            {

                if (serialPort1.IsOpen)
                {
                    try
                    {
                        String text = textBoxbri.Text;
                        serialPort1.Write("b " + text);
                        textBoxbri.Clear();
                    }
                    catch (Exception er)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //--------------------------------------------------------------

        //------ track bar for britness---------------------------------
        private void trackBarBir_Scroll(object sender, EventArgs e)
        {
            textBoxbri.Text = trackBarBir.Value.ToString();

        }
        //--------------------------------------------------------------

        //------------- for color button------------------------------  
        private void ColorD_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                
                String codeColor = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");


                if (serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Write("c " + codeColor);
                        ColorD.BackColor = colorDialog1.Color;
                    }
                    catch (Exception er)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
                


        }
        //------------------------------------------------------------

        //------------clear button ------------------------------------
        private void clear_Serila_Click(object sender, EventArgs e)
        {
            textBoxRead.Clear();
        }
        //-------------------------------------------------------------

        //----------------rest button---------------------------------
        private void rest_Arduino_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("f ");
                   
                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //-------------------------------------------------------------


        //----------------britness plus button-------------------------
        private void bri_plus_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("b+");

                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //-------------------------------------------------------------


        //--------------britness minus button-------------------------
        private void bri_mins_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("b-");

                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //------------------------------------------------------------

        //--------------speed plus buttton----------------------------
        private void speed_plus_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("s+");

                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //-----------------------------------------------------------

        //--------------speed minus button-------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("s-");

                }
                catch (Exception er)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Connecting First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //---------------------------------------------------------


        //-------------when click on icon next to colok--------------------------
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            ShowInTaskbar = true; // show app in taskbar.
        }
        //-----------------------------------------------------------------------


        //---------------when click on show in mnue-------------------------------
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            ShowInTaskbar = true; // show app in taskbar
        }
        //------------------------------------------------------------------------

        //----------when click on exit in mnue-----------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-----------------------------------------------------------------------


       //-----------------too move the forme to tray system (next to colok)--
        private void Form_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {              
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "The Application Minimized.", ToolTipIcon.Info);
            }
        }
        //-------------------------------------------------------------------
    }
}
