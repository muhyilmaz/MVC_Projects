using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arch.Core.Entities.Access
{
    public class Role
    {
        [Key]
        public byte Id {get; set;} 
        public string Name {get; set;}
    }
}
