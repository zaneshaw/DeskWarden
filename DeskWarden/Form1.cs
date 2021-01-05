using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net.Sockets;

namespace DeskWarden
{
    public partial class Form1 : Form
    {
        settings setting = new settings();
        public ContextMenu contextMenu1 = new ContextMenu();
        Point lastClick;

        public Form1()
        {
            InitializeComponent();
            randJoke();

            contextMenu1.MenuItems.Add("Settings", refocus);
            contextMenu1.MenuItems.Add("Exit", exit);

            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Desk Warden";
            notifyIcon1.ContextMenu = contextMenu1;
            settingsLoad();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(255, 25, 40, 66);
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
            int thickness = 3;
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000, "Notification Test", "Description", ToolTipIcon.None);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Minimized to system tray", "Double click the tray icon to reopen the control panel!", ToolTipIcon.Info);
            this.Hide();
        }

        private void exitBtn_Paint(object sender, PaintEventArgs e)
        {
            Control ctrl = sender as Control; ControlPaint.DrawBorder(e.Graphics, ctrl.ClientRectangle, ctrl.BackColor, ButtonBorderStyle.Solid);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void minBtn_Paint(object sender, PaintEventArgs e)
        {
            Control ctrl = sender as Control; ControlPaint.DrawBorder(e.Graphics, ctrl.ClientRectangle, ctrl.BackColor, ButtonBorderStyle.Solid);
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        private void interval1Slider_ValueChanged(object sender, EventArgs e)
        {
            interval1UpDown.Value = (int)interval1Slider.Value;
        }

        private void interval1UpDown_ValueChanged(object sender, EventArgs e)
        {
            interval1Slider.Value = (int)interval1UpDown.Value;
        }

        public object XmlFileManager { get; private set; }

        private void settingsSave()
        {
            try
            {
                if(state1Btn.CheckState == System.Windows.Forms.CheckState.Checked)
                {
                    setting.state1 = true;
                }
                else
                {
                    setting.state1 = false;
                }
                setting.interval1 = interval1Slider.Value;

                settingsManager.settingsWriter(setting, "./_data/settings.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }
        
        private void settingsLoad()
        {
            if (File.Exists("./_data/settings.xml"))
            {
                setting = settingsManager.settingsReader("./_data/settings.xml");

                
                if (setting.state1 == true)
                {
                    state1Btn.CheckState = System.Windows.Forms.CheckState.Checked;
                }
                else
                {
                    state1Btn.CheckState = System.Windows.Forms.CheckState.Unchecked;
                }

                try
                {
                    interval1Slider.Value = setting.interval1;
                }
                catch
                {
                    return;
                }
                Console.WriteLine("settings successfully loaded!");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            settingsSave();
        }

        private void state1Btn_CheckStateChanged(object sender, EventArgs e)
        {
            if (state1Btn.CheckState == CheckState.Checked)
            {
                state1Btn.Text = "Enabled";
            }
            else if (this.state1Btn.CheckState == CheckState.Unchecked)
            {
                state1Btn.Text = "Disabled";
            }
            else
            {
                Console.WriteLine("Unexpected error while changing task1 checked state");
            }
        }

        private void exit(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Environment.Exit(0);
        }
        
        private void refocus(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private static Random rand = new Random(DateTime.Now.Second);

        private void randJoke()
        {
            string fullJoke;
            //Jokes pulled from sheryllun/postureminder
            string[] jokePt1 = new string[20] { "Straighten up,", "Shoulders back,", "How\"s your posture,", "Check your posture,", "Sit up straight,", "Check yourself,", "No hunchbacks,", "At attention,", "Stop slumping,", "Mother told you not to slouch,", "Sit up,", "Posture Reminder,", "Posture police,", "Stop slouching,", "Back straight,", "Dump the slump,", "Posture check,", "Improve your posture,", "No bent spines,", "Mind your posture," };
            string[] jokePt2 = new string[14] { "young grasshopper.", "buddy.", "amigo.", "boss.", "partner.", "chap.", "pal.", "soldier.", "chum.", "mate.", "friend.", "comrade.", "cuz.", "homie." };

            fullJoke = jokePt1[rand.Next(0, jokePt1.Length - 1)] + " " + jokePt2[rand.Next(0, jokePt2.Length - 1)];
            Console.WriteLine(fullJoke);
        }

        private void dimForm()
        {
            
        }

        private void advancedBtn_Click(object sender, EventArgs e)
        {
            dimForm();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
