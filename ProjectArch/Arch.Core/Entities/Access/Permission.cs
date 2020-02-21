using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arch.Core.Entities.Access
{
    public class Permission
    {
        [Key]
        public short Id {get; set;} 
        public short ParentId {get; set;}
        public string Name {get; set;}
        public string Controller {get; set;}
        public string Action {get; set;}
        public string RawUrl{get; set;}
        public string Icon {get; set;}
        public short DisplayOrder {get; set;}
        public bool IsMenu {get; set;}
        public bool IsVisible {get; set;}
        public string Description {get; set;}
    }
}
