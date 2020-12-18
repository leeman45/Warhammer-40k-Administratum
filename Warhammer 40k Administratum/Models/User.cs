using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Warhammer_40k_Administratum.Models
{
    public class User
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter your Email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid Email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your Username")]
        public string Username { get; set; }
    }
}