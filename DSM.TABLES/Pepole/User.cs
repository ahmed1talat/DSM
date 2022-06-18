using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.TABLES.Base;

namespace DSM.TABLES.Pepole
{
    public class User :BaseEntity
    {

        public string  UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool  IsAdmin { get; set; }

        public ICollection<UserBranch> userBranches { get; set; }
        public ICollection<User> userCreated { get; set; }
        public ICollection<User> userModifided { get; set; }
        public ICollection<User> userDeleteed { get; set; }







    }
}
