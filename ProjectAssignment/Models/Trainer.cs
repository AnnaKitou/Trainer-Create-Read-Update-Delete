using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectAssignment.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only Letters From Aa to Zz Are Allowed.")]
        [StringLength(15,MinimumLength =2)]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only Letters From Aa to Zz Are Allowed.")]
        [StringLength(15, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [Range(20,67,ErrorMessage ="Age must be between 20 to 67 years old")]
        public int Age { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1)]
        public string Subject { get; set; }
    }
}