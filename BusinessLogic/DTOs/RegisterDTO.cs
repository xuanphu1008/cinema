using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class RegisterDTO
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public string eMail { get; set; }
        public string phoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
    }
}
