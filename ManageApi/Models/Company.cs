using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageApi.Models
{
    public class Company
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the name.")]
        [StringLength(50,ErrorMessage ="Cannot be more than 50.")]
        public string Name { get; set; }
        [StringLength(10, ErrorMessage = "Cannot be more than 10.")]
        [Phone(ErrorMessage = "Please enter a correct phone no.")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Please enter the code.")]
        [StringLength(2, ErrorMessage = "Cannot be more than 2.")]
        public string Code { get; set; }

        
        public byte[] CompanyPhoto { get; set; }

        public List<Customer> Customers { get; set; }

    }
}