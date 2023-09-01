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
    public partial class AddSubjet : Form
    {

        private bool isTurnOff = false;
        public bool IsTurnOff
        {
            get { return isTurnOff; }
            set { isTurnOff = value; }
        }
        private string subjectName = "";
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        private string semester = "";
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        private Color subjectColor = Color.FromArgb(116, 149, 154);
        public Color SubjectColor
        {
            get { return subjectColor; }
            set { subjectColor = value; this.ColorLabel.BackColor = subjectColor; this.ColorLabel.Invalidate(); }
        }
        private string iconChar = "Unity";
        public string IconChar
        {
             get { return iconChar; }
             set { this.iconChar = value;  }
        }
        private string pathToWorkSpace = "";
        public string PathToWorkSpace
        {
            get { return pathToWorkSpace; }
            set { pathToWorkSpace = value; }
        }
        public AddSubjet()
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
        private void Titile_MouseUp(object sender, MouseEventArgs e)
        {
            dragForm = false;
        }

        //private function
        private void TurnOff_Click(object sender, EventArgs e)
        {
            IsTurnOff = true;
            this.Close();
        }

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            SubjectColor = Color.FromArgb(116, 149, 154);
        }

        bool isIconExis = true;
        //Exception handler
        bool checkSemester(string semester)
        {
            foreach(char Item in semester)
            {
                if ((Item < '0' || Item > '9'))
                    return false;
            }
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(this.NameBox.Texs == "Subject name")
            {
                MessageBox.Show("Missing subject name!!. Try again.");
                return;
            }
            else if( this.NameBox.Texs.Length >24)
            {
                MessageBox.Show("Titile length must be smaller than 24 characters");
                return;
            }
            else
            {
                List<Dto.Subject> list = new List<Dto.Subject>();
                Bll.Subject.GetSubject getSubject = new Bll.Subject.GetSubject();
                getSubject.GetDataSubject(PathToWorkSpace, list);
                foreach (Dto.Subject Element in list)
                {
                    if(Element.SubjectName == this.NameBox.Texs)
                    {
                        MessageBox.Show("Subject is already existed. Try again.");
                        return;
                    }
                }
                this.SubjectName = this.NameBox.Texs;
            }
            if(this.SemesterBox.Texs != "Semester")
            {
                if(checkSemester(this.SemesterBox.Texs) == false)
                {
                    MessageBox.Show("Wrong semester format!!. Semester just has only number. Try again.");
                    return;
                }
                else
                {
                    this.Semester = this.SemesterBox.Texs;
                }
            }
            else
            {
                MessageBox.Show("Missing semester!!. Try again.");
                return;
            }
            //this.IconChar = (FontAwesome.Sharp.IconChar)Enum.Parse(typeof(FontAwesome.Sharp.IconChar), this.IconCombobox.Text);
            List<string> IconList = Enum.GetNames(typeof(FontAwesome.Sharp.IconChar)).ToList();
            if (IconList.Contains(this.IconCombobox.Text) == true)
            {
                if (this.IconCombobox.Text != "None")
                    this.IconChar = this.IconCombobox.Text;
            }

            MessageBox.Show("Create successfully.");
            this.Close();
        }

        private void AddSubjet_Load(object sender, EventArgs e)
        {
            List<string> IconList = Enum.GetNames(typeof(FontAwesome.Sharp.IconChar)).ToList();
            this.IconCombobox.DataSource = IconList;
            this.IconCombobox.Text = "Icon choice";
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
        private void IconCombobox_TextChanged(object sender, EventArgs e)
        {
            //this.iconPictureBox1.IconChar = (FontAwesome.Sharp.IconChar)Enum.Parse(typeof(FontAwesome.Sharp.IconChar), this.IconCombobox.Text); ; this.iconPictureBox1.Invalidate();
        }

        private void IconCombobox_TextUpdate(object sender, EventArgs e)
        {
            //this.iconPictureBox1.IconChar = (FontAwesome.Sharp.IconChar)Enum.Parse(typeof(FontAwesome.Sharp.IconChar), this.IconCombobox.Text); ; this.iconPictureBox1.Invalidate();
        }

        private void IconCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.iconPictureBox1.IconChar = (FontAwesome.Sharp.IconChar)Enum.Parse(typeof(FontAwesome.Sharp.IconChar), this.IconCombobox.Text); ; this.iconPictureBox1.Invalidate();
        }

        private void IconCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.iconPictureBox1.IconChar = (FontAwesome.Sharp.IconChar)Enum.Parse(typeof(FontAwesome.Sharp.IconChar), this.IconCombobox.Text); this.iconPictureBox1.Invalidate();
        }
    }
}
