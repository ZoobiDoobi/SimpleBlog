using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
       

        [Required]
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}