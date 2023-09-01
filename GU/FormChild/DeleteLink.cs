using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.FormChild
{
    public partial class DeleteLink : Form
    {
        public DeleteLink()
        {
            InitializeComponent();
        }
        private bool isExit = false;
        public bool IsExit
        {
            get { return isExit; }
            set { isExit = value; }
        }
        //Move form
        Point locationClicked;
        bool dragForm = false;
        private void Titile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                locationClicked = new Point(e.Location.X, e.Location.Y);
                dragForm = true;
            }
        }
        private void Titile_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragForm)
            {
                this.Location = new Point(this.Location.X + (e.X - locationClicked.X), this.Location.Y + (e.Y - locationClicked.Y));
            }
        }
        private void Titile_MouseUp(object sender, MouseEventArgs e)
        {
            dragForm = false;
        }

        //private function
        private void TurnOff_Click(object sender, EventArgs e)
        {
            isExit = true;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.isExit = false;
            this.Close();
        }
    }
}
