using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SqlQueries
{
    public class RegisterQueries
    {
        public const string InsertNewAccount = @"
            INSERT INTO accounts (fullName, eMail, phoneNumber, dateOfBirth, userName, passWord)
            VALUES (@FullName, @Email, @PhoneNumber, @DateOfBirth, @UserName, @PassWord)";

        public const string CheckUserExist = @"
            SELECT COUNT(*) FROM accounts WHERE userName = @UserName OR eMail = @Email OR phoneNumber = @PhoneNumber";
    }
}
