using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTK_Akademi_Proje1.Models
{
    public class Candidate
    {
        // String? bunun sonuna '?' koyulmasının sebebi boş geçilebilirdir.
        [Required(ErrorMessage ="E-mail is required.")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "FirstName is required.")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "LastName is required.")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }
}
