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
    public partial class ALinkNode : UserControl
    {
        public ALinkNode()
        {
            InitializeComponent();
        }
        private string accountName = "";
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private string timeStamp = "";
        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
        private string currentSubject = "";
        public string CurrentSubject
        {
            get { return currentSubject; }
            set { currentSubject = value; }
        }
        public string Titile
        {
            get { return this.TitileLabel.Text; }
            set { this.TitileLabel.Text = value; this.TitileLabel.Invalidate(); }
        }
        private string pathToWorkSpace = "";
        public string PathToWorkSpace
        {
            get { return pathToWorkSpace; }
            set { pathToWorkSpace = value; }
        }
        private string imageIcon = "";
        public string ImageIcon
        {
            get { return Path.GetFileName(this.pictureBox.ImageLocation); }
            set { imageIcon = value; this.pictureBox.Image = Image.FromFile(imageIcon); this.pictureBox.Invalidate(); }
        }

        private string url = "";
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        private Panel panel = new Panel();
        private string hobby = "";
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        public Panel Panel
        {
            get { return panel; }
            set { panel = value; }
        }
        //private function
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.MoreOption.Show(this.moreOptionButton,new Point(20,20),ToolStripDropDownDirection.BelowRight);
        }

        private void MoreOption_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ALinkNode_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ALinkNode_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void ALinkNode_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\\msedge.exe",this.Url);
        }

        private void MoreOption_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == this.MoreOption.Items[0])
            {
                Information();
            }
            else if(e.ClickedItem == this.MoreOption.Items[1])
            {
                ChangeInformation();
            }
            else
            {
                PinToTop();
            }
        }
        private void Information()
        {
            FormChild.DataLink dataLink = new FormChild.DataLink();
            dataLink.TitileLink = this.Titile;
            dataLink.Author = this.AccountName;
            dataLink.Time = this.TimeStamp;
            dataLink.Url = this.Url;

            dataLink.StartPosition = FormStartPosition.CenterParent;
            dataLink.ShowDialog();
        }
        private void ChangeInformation()
        {
            List<Dto.Link> List = new List<Dto.Link>();
            Bll.Link.GetData getData = new Bll.Link.GetData();
            getData.ReadData(CurrentSubject, List, PathToWorkSpace);

            int count, row, column;
            count = row = column = 0;

            FormChild.AddLink addLink = new FormChild.AddLink();
            addLink.StartPosition = FormStartPosition.CenterParent;
            addLink.label2.Text = "Change Link Information";
            addLink.NameBox.TextGround = this.Titile;
            addLink.UrlBox.TextGround = this.Url;
            addLink.NameBox.IsLoseText = false;
            addLink.UrlBox.IsLoseText = false;
            addLink.Hobby = this.Hobby;
            addLink.PathToWorkSpace = this.PathToWorkSpace;
            addLink.ShowDialog();

            if (addLink.isTurnOff == true)
                return;

            FormChild.DataForm dataForm = new FormChild.DataForm();
            dataForm.TopLevel = false;
            Panel.Controls.Add(dataForm);
            dataForm.Dock = DockStyle.Fill;
            dataForm.BringToFront();

            foreach(Dto.Link link in List)
            {
                if(link.Title == this.Titile)
                {
                    link.Title = addLink.TitileLink;
                    link.IconImage = addLink.IconLink;
                    link.Url = addLink.Url;
                    link.TimeStamp = ((int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString();
                    break;
                }
            }

            foreach (Dto.Link item in List)
            {
                FormChild.ALinkNode aLinkNode = new FormChild.ALinkNode();
                aLinkNode.Panel = Panel;
                aLinkNode.Titile = item.Title;
                aLinkNode.Dock = DockStyle.Fill;
                aLinkNode.ImageIcon = item.IconImage;
                aLinkNode.PathToWorkSpace = this.PathToWorkSpace;
                aLinkNode.Margin = new System.Windows.Forms.Padding(10);
                aLinkNode.Url = item.Url;
                aLinkNode.CurrentSubject = CurrentSubject;
                aLinkNode.AccountName = item.AccountName;
                aLinkNode.TimeStamp = item.TimeStamp;
                aLinkNode.Hobby = this.Hobby;

                row = count / 4;
                column = count - 4 * row;
                dataForm.DataTable.Controls.Add(aLinkNode, column, row);

                count++;
            }

            dataForm.Show();

            Bll.Link.SaveData saveData = new Bll.Link.SaveData();
            saveData.SaveLink(CurrentSubject, List, PathToWorkSpace);
        }
        private void PinToTop()
        {
            Dto.Link OldLink = new Dto.Link();

            List<Dto.Link> List = new List<Dto.Link>();
            Bll.Link.GetData getData = new Bll.Link.GetData();
            getData.ReadData(CurrentSubject, List, PathToWorkSpace);

            int count, row, column;
            count = row = column = 0;

            if (List.Count <= 1)
                return;

            FormChild.DataForm dataForm = new FormChild.DataForm();
            dataForm.TopLevel = false;
            Panel.Controls.Add(dataForm);
            dataForm.Dock = DockStyle.Fill;
            dataForm.BringToFront();

            count = 0;
            foreach (Dto.Link link in List)
            {
                if (link.Title == this.Titile)
                {
                    if (count == 0)
                        return;
                    List.Insert(0, link);
                    List.RemoveAt(count+1);
                    break;
                }
                count++;
            }
            count = 0;
            foreach (Dto.Link item in List)
            {
                FormChild.ALinkNode aLinkNode = new FormChild.ALinkNode();
                aLinkNode.Panel = Panel;
                aLinkNode.Titile = item.Title;
                aLinkNode.Dock = DockStyle.Fill;
                aLinkNode.ImageIcon = item.IconImage;
                aLinkNode.PathToWorkSpace = this.PathToWorkSpace;
                aLinkNode.Margin = new System.Windows.Forms.Padding(10);
                aLinkNode.Url = item.Url;
                aLinkNode.CurrentSubject = CurrentSubject;
                aLinkNode.AccountName = item.AccountName;
                aLinkNode.TimeStamp = item.TimeStamp;
                aLinkNode.Hobby = this.Hobby;

                row = count / 4;
                column = count - 4 * row;
                dataForm.DataTable.Controls.Add(aLinkNode, column, row);

                count++;
            }

            dataForm.Show();

            Bll.Link.SaveData saveData = new Bll.Link.SaveData();
            saveData.SaveLink(CurrentSubject, List, PathToWorkSpace);

        }
    }
}
