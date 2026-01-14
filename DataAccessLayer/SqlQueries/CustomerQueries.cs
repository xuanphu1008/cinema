using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SqlQueries
{
    public class CustomerQueries
    {
        public const string GetAllCustomers = @"
            SELECT ID, fullName, eMail, phoneNumber, dateOfBirth, userName
            FROM Accounts";



        public const string DeleteCustomer = "DELETE FROM Accounts WHERE ID = @ID";

        public const string SearchCustomers = @"
            SELECT * FROM Accounts 
            WHERE fullName LIKE @Keyword 
               OR eMail LIKE @Keyword 
               OR userName LIKE @Keyword";

    }
}