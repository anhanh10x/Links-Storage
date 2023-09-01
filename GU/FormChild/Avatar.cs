using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dto;
namespace Gui.FormChild
{
    public partial class Avatar : Form
    {
        public MainForm mainForm = new MainForm();
        public Dto.Account CurrentAccount = new Dto.Account();
        public Avatar()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChild.AccountForm accountForm = new FormChild.AccountForm();
            accountForm.StartPosition = FormStartPosition.CenterScreen;
            accountForm.TitileLabel.Text = "Change Account Information";
            accountForm.NameBox.TextGround = this.CurrentAccount.AccountName;
            accountForm.EmailBox.TextGround = this.CurrentAccount.Email;
            accountForm.NameBox.IsLoseText = false;
            accountForm.EmailBox.IsLoseText = false;
            accountForm.PathToImage = this.CurrentAccount.PathToImage;
            accountForm.ShowDialog();

            if (accountForm.isTurnOff == true)
                return;

            CurrentAccount = new Account(accountForm.AccountName, accountForm.Email, accountForm.PathToImage, accountForm.PathToWorkSpace,accountForm.Hobby);
            Bll.Account.SaveDataAccount saveDataAccount = new Bll.Account.SaveDataAccount();
            mainForm.Hide();
            MainForm form = new MainForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = mainForm.Location;
            form.promotoForm = mainForm.promotoForm;
            saveDataAccount.SaveAccount(CurrentAccount);
            form.ShowDialog();
            this.Close();
        }

        private void AvatarForm_Load(object sender, EventArgs e)
        {
            this.AccountName.Text = CurrentAccount.AccountName;
            this.EmailLabel.Text = CurrentAccount.Email;
            this.rjCircularPictureBox1.Image = Image.FromFile(CurrentAccount.PathToImage);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Avatar_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }
    }
}
