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
    public partial class DataLink : Form
    {
        public DataLink()
        {
            InitializeComponent();
        }

        //Field
        private string titileLink = "";
        public string TitileLink
        {
            get { return titileLink; }
            set { titileLink = value; }
        }
        private string author = "";
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string time = "";
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        private string url = "";
        public string Url
        {
            get { return url; }
            set { url = value; }
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
            this.Close();
        }

        private void DataLink_Load(object sender, EventArgs e)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            this.TitileData.Text = this.titileLink;
            this.TimeLabel.Text = (origin.AddSeconds(Int32.Parse(this.Time)).ToLocalTime()).ToString("dd/MM/yyyy HH:mm:ss");
            this.AuthorLabel.Text = this.author;
            this.UrlLabel.Text = this.url;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
