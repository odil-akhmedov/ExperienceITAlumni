﻿﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace ExperienceITAlumni.Models
{
    public class Members
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UploadPhoto { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string Google { get; set; }
        public string FaceBook { get; set; }
        public string PhoneNumber { get; set; }
        public string Resume { get; set; }
        public string EmployerName { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }


        public virtual ApplicationUser User { get; set; }
    }
}