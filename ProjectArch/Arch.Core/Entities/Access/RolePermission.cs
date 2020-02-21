using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arch.Core.Entities.Access
{
    public class RolePermission
    {
        [Key]
        public int Id {get; set;} 
        public byte RoleId {get; set;}
        public short PermissionId {get; set;}
    }
}
