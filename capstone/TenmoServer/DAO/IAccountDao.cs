﻿using System.Collections.Generic;
using TenmoServer.Models;

namespace TenmoServer.DAO
{
    public interface IAccountDao
    {
        Account GetAccountByAccountId(int accountId);
        Account GetAccountByUser(int userId);
        decimal AccountBalance(int accountId);

        int GetUserIdByAccountId(int accountId);
        string GetUsernameByAccountId(int accountId);
    }
}
