using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asign4Vishal.Models
{
    public class MyContext:DbContext
    {
       public MyContext() : base("MyContext") {
        
        }

       public  DbSet<User> users {  get; set; }


    }

    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Designation { get; set;}
    
    
    
    }


}