using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.FormChild
{

    public partial class PromotoForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void LockWorkStation();
        int downSumSecond =1500, upSumSecond = 0;
        int downMinute = 0, downSecond = 0, downHour = 0;
        int upMinute = 0, upSecond = 0, upHour = 0;

        bool isHardOn = false;
        private void HardStart_Click(object sender, EventArgs e)
        {
            if (isHardOn == false)
            {
                if (MessageBox.Show("If you turn on hard mode, you can not turn off this mode. \nAre you sure?", "Warining", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.timer1.Enabled = true;
                    this.timer1.Start();
                    this.HardStart.Text = "Stop";
                    this.ForeColor = Color.OrangeRed;
                    this.NormalStart.Hide();
                    this.HardStart.Hide();
                    isHardOn = true;
                }
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                this.HardStart.Text = "Hard Start";
                this.ForeColor = Color.Silver;
                this.NormalStart.Show();
                isHardOn = false;
            }
        }

        bool isNormalOn = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset?", "Reset", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (isNormalOn == true && isBreak == false)
                {
                    isBreak = false;
                    downSumSecond = 1500;
                    this.timer1.Enabled = false;
                    this.timer1.Stop();
                    this.NormalStart.Text = "Normal Start";
                    this.ForeColor = Color.Silver;
                    this.HardStart.Show();
                    isNormalOn = false;
                    this.CountDownTime.Text = "25:00";
                    this.CountUpTime.Text = "00:00:00";
                }
            }
        }

        private void NormalStart_Click(object sender, EventArgs e)
        {
            if (isNormalOn == false)
            {
                this.timer1.Enabled = true;
                this.timer1.Start();
                this.NormalStart.Text = "Stop";
                this.ForeColor = Color.OrangeRed;
                this.HardStart.Hide();
                isNormalOn = true;
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                this.NormalStart.Text = "Normal Start";
                this.ForeColor = Color.Silver;
                this.HardStart.Show();
                isNormalOn = false;
            }
        }

        public PromotoForm()
        {
            InitializeComponent();
        }
        string returnCorrectForm(int number)
        {
            if(number <10)
            {
                return "0" + number.ToString();
            }
            return number.ToString();
        }
        bool isBreak = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            downSumSecond -= 1;
            downHour = downSumSecond / 3600;
            downMinute = (downSumSecond - downHour * 3600) / 60;
            downSecond = (downSumSecond - downHour * 3600 - downMinute*60);

            if(downSecond == 0 && downMinute == 0)
            {
                if(isBreak == false)
                {
                    isBreak = true;
                    downSumSecond = 300;
                    LockWorkStation();
                }
                else
                {
                    isBreak = false;
                    downSumSecond = 1500;
                }
            }

            upSumSecond += 1;
            upHour = upSumSecond / 3600;
            upMinute = (upSumSecond - upHour * 3600) / 60;
            upSecond = (upSumSecond - upHour * 3600 - upMinute*60);

            this.CountDownTime.Text = returnCorrectForm(downHour) + " : " + returnCorrectForm(downMinute) + " : " + returnCorrectForm(downSecond);
            this.CountDownTime.Invalidate();

            this.CountUpTime.Text = returnCorrectForm(upHour) + " : " + returnCorrectForm(upMinute) + " : " + returnCorrectForm(upSecond);
            this.CountUpTime.Invalidate();
        }
    }
}
