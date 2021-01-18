using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectUsingSelenium1
{
    class EditUserDto
    {
        public string editUserFirstName { get; set; }
        public string editUserLastName { get; set; }
        public string editUserEmail { get; set; }
        public string currentPassword { get; set; }
        public string newPassword { get; set; }
        public string confirmationPassword { get; set; }

    }
}
