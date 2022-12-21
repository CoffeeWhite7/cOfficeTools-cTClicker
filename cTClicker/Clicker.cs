using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cTClicker
{
    public partial class Clicker : Form
    {
        public Clicker()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            clickMode.SelectedIndex = 0;
            clicktimeUpDown.Value = 30;
            
        }

        HotKeys hotKsys = new HotKeys();

        private void Clicker_Load(object sender, EventArgs e)
        {
            hotKsys.Regist(this.Handle, (int)HotKeys.HotkeyModifiers.Alt, Keys.C, StartClick);//Alt+C
            hotKsys.Regist(this.Handle, (int)HotKeys.HotkeyModifiers.Control + (int)HotKeys.HotkeyModifiers.Alt, Keys.E, Exit);//Ctrl+Alt+E
            hotKsys.Regist(this.Handle, (int)HotKeys.HotkeyModifiers.Shift, Keys.C, ColorT);//Shift+C
        }




        void StartClick()
        {
            
            if(clicktimeUpDown.Value <= 0) { clicktimeUpDown.Value = 1; }
            click_tmr.Interval = (int)clicktimeUpDown.Value;
            if (click_tmr.Enabled)
            {
                click_tmr.Enabled = false;
                this.Enabled = true;
            }
            else
            {
                click_tmr.Enabled = true;
                this.Enabled = false;
            }
        }

        void Exit()
        {
            Application.Exit();
        }

        void ColorT()
        {
            if(this.BackColor != Color.WhiteSmoke)
            { 
                this.BackColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.FromArgb(255,240,240,240);
            }
            

        }

        protected override void WndProc(ref Message m)
        {
            hotKsys.ProcessHotKey(m);
            base.WndProc(ref m);
        }

        private void Clicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            hotKsys.UnRegist(this.Handle, StartClick);
        }
        class Mouse
        {
            [System.Runtime.InteropServices.DllImport("user32")]
            public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
            //移动鼠标 
            public const int MOUSEEVENTF_MOVE = 0x0001;
            //模拟鼠标左键按下 
            public const int MOUSEEVENTF_LEFTDOWN = 0x0002; 
            //模拟鼠标左键抬起 
            public const int MOUSEEVENTF_LEFTUP = 0x0004;
            //模拟鼠标右键按下 
            public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
            //模拟鼠标右键抬起 
            public const int MOUSEEVENTF_RIGHTUP = 0x0010;
            //模拟鼠标中键按下 
            public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
            //模拟鼠标中键抬起 
            public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
            //标示是否采用绝对坐标 
            public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
            [DllImport("user32.dll")]
            public static extern bool SetCursorPos(int X, int Y);
        }

        private void click_tmr_Tick(object sender, EventArgs e)
        {
            if     (clickMode.SelectedIndex== 0) {Mouse.mouse_event(Mouse.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                                  Mouse.mouse_event(Mouse.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);}//左键
            else if(clickMode.SelectedIndex== 1) {Mouse.mouse_event(Mouse.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                                                  Mouse.mouse_event(Mouse.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);}//右
            else if(clickMode.SelectedIndex== 2) {Mouse.mouse_event(Mouse.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                                  Mouse.mouse_event(Mouse.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                                                  Mouse.mouse_event(Mouse.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                                                  Mouse.mouse_event(Mouse.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);}//左+右
            else if(clickMode.SelectedIndex== 3) {Mouse.mouse_event(Mouse.MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                                                  Mouse.mouse_event(Mouse.MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);}//中
            
        }
    }
}
