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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        private string hobby = "Food";
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }

        private string pathToWorkSpace = "";
        public string PathToWorkSpace
        {
            get { return pathToWorkSpace; }
            set { pathToWorkSpace = value; }
        }

        private string pathToImage = "";
        public string PathToImage
        {
            get { return pathToImage; }
            set { pathToImage = value; }
        }

        private string accountName = "";
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private string email = "";
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool isTurnOff = false;
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
        private void ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.PathToImage = openFileDialog.FileName;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (this.NameBox.Texs == "Account name")
            {
                MessageBox.Show("Missing subject name!!. Try again.");
                return;
            }
            else
            {
                this.AccountName = this.NameBox.Texs;
            }
            //this.IconChar = (FontAwesome.Sharp.IconChar)Enum.Parse(typeof(FontAwesome.Sharp.IconChar), this.IconCombobox.Text);
            if(this.PathToImage == "")
            {
                MessageBox.Show("Missing path to image!! Try again.");
                return;
            }

            if (this.EmailBox.Texs == "")
            {
                MessageBox.Show("Missing Email!! Try again.");
                return;
            }
            else
            {
                this.Email = this.EmailBox.Texs;
            }
            if(this.IconCombobox.Items.Contains(this.IconCombobox.Text) == true)
            {
                this.Hobby = this.IconCombobox.Text;
            }
            MessageBox.Show("Create successfully.");
            this.Close();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +"\\Studying App");
            this.PathToWorkSpace = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Studying App";

            this.IconCombobox.Items.Add("Food");
            this.IconCombobox.Items.Add("Animal");
            this.IconCombobox.Items.Add("Technology");
            this.IconCombobox.Items.Add("Magic");
            this.IconCombobox.Items.Add("Nature");
            this.IconCombobox.Items.Add("Education");
            this.IconCombobox.Items.Add("Travel");
        }

        private void TurnOff_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                isTurnOff = true;
                this.Close();
            }
            else
            {

            }
        }
        private void IconCombobox_Enter(object sender, EventArgs e)
        {
            if (this.IconCombobox.Text == "Your hobby")
            {
                this.IconCombobox.Text = "";
            }
        }

        private void IconCombobox_Leave(object sender, EventArgs e)
        {
            if (this.IconCombobox.Text == "")
            {
                this.IconCombobox.Text = "Your hobby";
            }
        }
    }
}
