using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SqlQueries
{
    public class EmployeeQueries
    {
        public const string AddEmployee = @"
            INSERT INTO Employee 
            (employee_name, gender, date_of_birth, shift, phone_number, salary, role, username, password) 
            VALUES 
            (@EmployeeName, @Gender, @DateOfBirth, @Shift, @PhoneNumber, @Salary, @Role, @UserName, @Password)";

        public const string CheckEmployeeExists = "SELECT COUNT(*) FROM Employee WHERE employee_id = @EmployeeId";

        public const string GetAllEmployees = @"
            SELECT 
                employee_id, 
                employee_name, 
                gender, 
                date_of_birth, 
                shift, 
                phone_number, 
                salary,  
                role
            FROM Employee";

        public const string SearchEmployees = @"SELECT 
                                                    employee_name,
                                                    gender,
                                                    date_of_birth,
                                                    shift,
                                                    phone_number,
                                                    salary,
                                                    role 
                                                FROM Employee WHERE employee_name LIKE @EmployeeName";

        public const string DeleteEmployee = "DELETE FROM Employee WHERE employee_id = @EmployeeId";

        public const string UpdateEmployee = @"
                                                UPDATE Employee 
                                                SET
                                                    employee_name = @EmployeeName,
                                                    gender = @Gender,
                                                    date_of_birth = @DateOfBirth,
                                                    shift = @Shift,
                                                    phone_number = @PhoneNumber,
                                                    salary = @Salary,
                                                    role = @Role
                                                WHERE employee_id = @EmployeeId";
    }
}
