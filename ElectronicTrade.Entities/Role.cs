using ElectronicTrade.Entities.EntityEnums.UserRoleType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Role
    {
        public Role()
        {
            user_roles = new List<User_Role>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleType RoleType { get; set; }
        public List<User_Role> user_roles { get; set; }
    }
}
