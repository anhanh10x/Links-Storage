using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Account
{
    public class SaveDataAccount
    {
        public void SaveAccount(Dto.Account account)
        {
            Dal.Account.SaveAccount saveAccount = new Dal.Account.SaveAccount();
            saveAccount.SaveDataAccount(account);
        }
    }
}
