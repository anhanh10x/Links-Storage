using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Account
    {
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
        private string hobby = "";
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        public Account(string AccountName = "", string Email = "", string PathToImage = "", string PathToWorkSpace = "", string Hobby = "")
        {
            this.AccountName = AccountName;
            this.Email = Email;
            this.PathToImage = PathToImage;
            this.PathToWorkSpace = PathToWorkSpace;
            this.Hobby = Hobby;
        }
    }
}
