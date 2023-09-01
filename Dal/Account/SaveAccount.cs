using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Account
{
    public class SaveAccount
    {
        public void SaveDataAccount(Dto.Account account)
        {
            StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Account.txt");
            streamWriter.WriteLine(account.AccountName);
            streamWriter.WriteLine(account.PathToWorkSpace);
            streamWriter.WriteLine(account.PathToImage);
            streamWriter.WriteLine(account.Email);
            streamWriter.WriteLine(account.Hobby);
            streamWriter.Close();
        }
    }
}
