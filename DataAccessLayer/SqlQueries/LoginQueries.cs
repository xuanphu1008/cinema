using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SqlQueries
{
    public class LoginQueries
    {
        public const string CheckUserInfor = @"
            SELECT COUNT(*) FROM employee WHERE username = @UserName AND password = @PassWord";

        public const string GetUserRole = @"
        SELECT role 
        FROM employee 
        WHERE username = @UserName AND password = @PassWord";

        public const string GetUsersWithoutRole = @"
            SELECT userName FROM accounts WHERE role IS NULL OR role = ''";

        public const string UpdateUserRole = @"
            UPDATE employee SET role = @Role WHERE username = @UserName";

    }
}
