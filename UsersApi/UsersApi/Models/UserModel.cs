using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApi.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordH { get; set; }
        public byte[] PasswordS { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
