using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudwithDataAnnotation.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Enter Your Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(20,120, ErrorMessage = "Age must be between 20 to 120")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is Required")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        
        public DateTime JoiningDate { get; set; }

    }
}