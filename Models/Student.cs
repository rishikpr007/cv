using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace cv.Models
{
    public class Student : IValidatableObject 
    {
        [Key]
        public int Id { get; set; }


        [Required (ErrorMessage ="Please Enter Student's Name")]
        [Display(Name="Student's Name")]
        [MaxLength(20,ErrorMessage ="Name can not exceed 20 letters")]
        public string Name { get; set; }


        [Required]
        //[Display(Name = "Student's Age")]
        //[Range(3, 25)]
        public int Age { get; set; }


        [Required (ErrorMessage ="Please Enter Mobile Number")]
        [Display(Name = "Mobile No")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public double Mobile { get; set; }

                

        [Required]
        [Display(Name = "Email Address")]
        [Validations(allowedDomain:"gmail.in")]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([cognizant]+\\.)+[com]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Age > 25)
            {
                yield return new ValidationResult("Age Sholul be less than 25");
            }
           
            if (Age < 3)
            {
                yield return new ValidationResult("Age should be greater than 3");
            }
        }
    }
} 
