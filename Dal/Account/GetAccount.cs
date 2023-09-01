using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Account
{
    public class GetAccount
    {
        public void GetDataAccount(Dto.Account account)
        {
            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Account.txt") == false)
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Account.txt", true);
                streamWriter.Close();
            }
            StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Account.txt");
            account.AccountName = streamReader.ReadLine();
            if(account.AccountName == "")
            {
                streamReader.Close();
                return;
            }
            account.PathToWorkSpace = streamReader.ReadLine();
            account.PathToImage = streamReader.ReadLine();
            account.Email = streamReader.ReadLine();
            account.Hobby = streamReader.ReadLine();
            streamReader.Close();
        }
    }
}
