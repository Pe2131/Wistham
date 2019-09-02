using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wistham.ViewModel
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public String Password { get; set; }
    }
}
