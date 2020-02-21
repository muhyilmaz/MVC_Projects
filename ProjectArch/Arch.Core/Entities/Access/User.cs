using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arch.Core.Entities.Access
{
    public class User
    {
        [Key]
        public int Id {get; set;} 
        public string Initials {get; set;}
        public string Name {get; set;}
        public string Surname{get; set;}
        public string Email {get; set;}
        public string Password{get; set;}
        public byte FailedLoginCount {get; set;}
        public System.DateTime? BlockedTime {get; set;}
        public bool IsActive {get; set;}
        public bool IsBlock {get; set;}
        public System.DateTime RegisterDate {get; set;}
    }
}
