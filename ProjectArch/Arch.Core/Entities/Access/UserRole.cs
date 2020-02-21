using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arch.Core.Entities.Access
{
    public class UserRole
    {
        [Key]
        public int Id {get; set;} 
        public int UserId {get; set;}
        public byte RoleId {get; set;}
    }
}
