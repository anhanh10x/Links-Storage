using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Account
{
    public class GetAccount
    {
        public void GetDataAccount(Dto.Account account)
        {
            Dal.Account.GetAccount getAccount = new Dal.Account.GetAccount();
            getAccount.GetDataAccount(account);
        }
    }
}
