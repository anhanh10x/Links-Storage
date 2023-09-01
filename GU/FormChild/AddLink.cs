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
    public partial class AddLink : Form
    {
        private string subject = "";
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        private string titile = "";
        public string TitileLink
        {
            get { return titile; }
            set { titile = value; }
        }
        private string url = "";
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        private string iconLink = Application.StartupPath + "Technology\\Robotic.png";
        public string IconLink
        {
            get { return iconLink; }
            set { iconLink = value; }
        }
        public AddLink()
        {
            InitializeComponent();
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
        private string hobby = "";
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        private void Titile_MouseUp(object sender, MouseEventArgs e)
        {
            dragForm = false;
        }

        public bool isTurnOff = false;
        //private function
        private string CutLink(string temp)
        {
            return temp.Substring(0,temp.LastIndexOf('.'));
        }
        private void TurnOff_Click(object sender, EventArgs e)
        {
            isTurnOff = true;
            this.Close();
        }
        private string pathToWorkSpace = "";
        public string PathToWorkSpace
        {
            get { return pathToWorkSpace; }
            set { pathToWorkSpace = value; }
        }
        private void AddLink_Load(object sender, EventArgs e)
        {
            string[] fileEntries = Directory.GetFiles(Application.StartupPath + Hobby);
            foreach (string fileName in fileEntries)
            {
                this.IconCombobox.Items.Add(CutLink(Path.GetFileName(fileName)));
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.NameBox.Texs == "Titile")
            {
                MessageBox.Show("Missing subject name!!. Try again.");
                return;
            }
            else
            {
                List<Dto.Link> list = new List<Dto.Link>();
                Bll.Link.GetData getData = new Bll.Link.GetData();
                getData.ReadData(Subject,list, PathToWorkSpace);
                foreach (Dto.Link Element in list)
                {
                    if (Element.Title == this.NameBox.Texs || Element.Url == this.UrlBox.Texs)
                    {
                        if(Element.Url == this.UrlBox.Texs)
                        {
                            MessageBox.Show("Link to web is already existed(in title: " + Element.Title + "). Try again. ");
                            return;
                        }
                        if (Element.Title == this.NameBox.Texs)
                        {
                            MessageBox.Show("Titile is already existed. Try again.");
                            return;
                        }
                    }
                }
                this.TitileLink = this.NameBox.Texs;
            }
            if (this.UrlBox.Texs != "Url")
            {
                this.Url = this.UrlBox.Texs;
            }
            else
            {
                MessageBox.Show("Missing url!!. Try again.");
                return;
            }
            //this.IconChar = (FontAwesome.Sharp.IconChar)Enum.Parse(typeof(FontAwesome.Sharp.IconChar), this.IconCombobox.Text);
            
            string[] fileEntries = Directory.GetFiles(Application.StartupPath + Hobby);
            List<string> List = new List<string>(); 
            foreach(string fileEntry in fileEntries)
            {
                List.Add(CutLink(Path.GetFileName(fileEntry)));
            }
            if (List.Contains(this.IconCombobox.Text) == true)
            {
                foreach(string fileEntry in fileEntries)
                {
                    if(CutLink(Path.GetFileName(fileEntry)) == this.IconCombobox.Text)
                    {
                        this.IconLink = fileEntry;
                    }
                }
            }
            MessageBox.Show("Create successfully.");
            this.Close();
        }

        private void IconCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] fileEntries = Directory.GetFiles(Application.StartupPath + Hobby);
            foreach (string fileEntry in fileEntries)
            {
                if(CutLink(Path.GetFileName(fileEntry)) == this.IconCombobox.Text)
                {
                    this.pictureBox1.Image = Image.FromFile(fileEntry);
                }
            }
        }

        private void IconCombobox_Click(object sender, EventArgs e)
        {
            
        }

        private void IconCombobox_Enter(object sender, EventArgs e)
        {
            if (this.IconCombobox.Text == "Icon choice")
            {
                this.IconCombobox.Text = "";
            }
        }

        private void IconCombobox_Leave(object sender, EventArgs e)
        {
            if (this.IconCombobox.Text == "")
            {
                this.IconCombobox.Text = "Icon choice";
            }
        }

        private void IconCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }
}
