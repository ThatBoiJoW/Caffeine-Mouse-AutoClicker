using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;   // Needed for API function calls
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caffine_Mouse_Autoclicker
{
    public partial class Form1 : Form
    {
        // Import Windows API funtion for simulating mouse events 
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // Import Windows API functions for registering and unregistering hotkeys
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MODE_NONE = 0x0000;
        const int WM_HOTKEY = 0x0312;

        // Mouse event flags for mouse_event API
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        // Hotkeys IDs for indetification when handling key presses
        private const int HOTKEY_ID_START = 1;
        private const int HOTKEY_ID_STOP = 2;

        // Timer that triggers mouse clicks
        Timer clickerTimer = new Timer();

        // Variables to store chosen start and stop hotkeys
        Keys startHotkey;
        Keys stopHotkey;

        public Form1()
        {
            InitializeComponent();

            // Populate hotkey combo boxes with all availale keys 
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                comboHotKeyStart.Items.Add(key);
                comboHotKeyStop.Items.Add(key);
            }

            // Set default hotkeys
            comboHotKeyStart.SelectedItem = Keys.F6;
            comboHotKeyStop.SelectedItem = Keys.F7;

            // Populate mouse button selection
            comboMouse.Items.Add("Left");
            comboMouse.Items.Add("Right");
            comboMouse.SelectedIndex = 0;

            // Populate click type selection
            comboAction.Items.Add("Click");
            comboAction.Items.Add("Double Click");
            comboAction.SelectedIndex = 0;

            // Assign click action to timer tick event
            clickerTimer.Tick += (s, e) => PerformClick();
        }


        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            PerformClick();
        }

        // Executes a mouse click (single or double, left or right) based on user selection.
        private void PerformClick()
        {
            bool isLeft = comboMouse.SelectedItem.ToString() == "Left";
            bool isDouble = comboAction.SelectedItem.ToString() == "Double Click";

            uint down = isLeft ? MOUSEEVENTF_LEFTDOWN : MOUSEEVENTF_RIGHTDOWN;
            uint up = isLeft ? MOUSEEVENTF_LEFTUP : MOUSEEVENTF_RIGHTUP;

            mouse_event(down, 0, 0, 0, 0);
            mouse_event(up, 0, 0, 0, 0);

            if (isDouble)
            {
                mouse_event(down, 0, 0, 0, 0);
                mouse_event(up, 0, 0, 0, 0);
            }
        }

        // Starts the autoclicker with the specified interval
        private void button1_Click(object sender, EventArgs e)
        {
            int interval = (int)(numHours.Value * 3600000 +
                                 numMin.Value * 60000 +
                                 numSec.Value * 1000 +
                                 numMilSec.Value);

            if (interval <= 0)
            {
                MessageBox.Show("Please set a valid interval PLEEEEAAASSE.");
                return;
            }

            clickerTimer.Interval = interval;
            clickerTimer.Start();
        }

        // Stops the autoclicker
        private void btnStop_Click(object sender, EventArgs e)
        {
            clickerTimer.Stop();
        }


        // Empty placeholder event handlers
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == startHotkey)
            {
                btnStart.PerformClick();
            }

            else if (e.KeyCode == stopHotkey)
            {
                btnStop.PerformClick();
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        // Alternative method for clicking mouse (similar to PerformClick).
        private void ClickMouse(object sender, EventArgs e)
        {
            bool isLeft = comboMouse.SelectedItem.ToString() == "Left";
            bool isDouble = comboAction.SelectedItem.ToString() == "Double Click";

            if (isLeft)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                if (isDouble)
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
            else
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                if (isDouble)
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            }
        }


        // Register hotkeys fo starting and stopping the autoclicker.
        private void btnRegisterHotkeys_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_START);
            UnregisterHotKey(this.Handle, HOTKEY_ID_STOP);

            Keys startHotKey = (Keys)comboHotKeyStart.SelectedItem;
            Keys stopHotKey = (Keys)comboHotKeyStop.SelectedItem;

            RegisterHotKey(this.Handle, HOTKEY_ID_START, 0, startHotKey);
            RegisterHotKey(this.Handle, HOTKEY_ID_STOP, 0, stopHotKey);

            MessageBox.Show($"Hotkeys Registered:\nStart = {startHotKey}\nStop = {stopHotKey}");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            clickerTimer.Stop();        // Stop timer before exiting
            this.Close();
        }

        // Override WndProc to handle global hotkey presses
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID_START)
                {
                    btnStart.PerformClick();
                }
                else if (id == HOTKEY_ID_STOP)
                {
                    btnStop.PerformClick();
                }
            }
            base.WndProc(ref m);
        }

        // Unregister hotkeys when the form closes
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_START);
            UnregisterHotKey(this.Handle, HOTKEY_ID_STOP);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}