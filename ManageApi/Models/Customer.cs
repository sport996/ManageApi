using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageApi.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the name.")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50.") ]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the job.")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50.")]
        
        public string Job { get; set; }

        [StringLength(10, ErrorMessage = "Cannot be more than 10.")]
        [Phone(ErrorMessage = "Please enter a correct phone no.")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Please enter the email.")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50.")]
        [EmailAddress(ErrorMessage = "Please enter a correct mail.")]
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }

        [Required]
        public Company CompanyID { get; set; }

    }
}