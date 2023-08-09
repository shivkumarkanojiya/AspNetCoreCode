using System.ComponentModel.DataAnnotations;

namespace ValidationAttributeAspDotCore.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please Enter Name.")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Email.")]
        // [EmailAddress]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage ="Please Enter Valid Email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Age.")]
        [Range(10,50)]
        public int? Age { get; set; }

        //[Required(ErrorMessage = "Please Enter Password.")]
        //[RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Uppercase,Lowercase,Number,Symbol,Minimum 8 charcter")]
        //public string Password { get; set; }
        //[Required(ErrorMessage = "Please Enter Confirm Password.")]
        //[Compare("Password",ErrorMessage ="Passord must be same")]
        //public string Confirmpassword { get; set; }
        //[Required(ErrorMessage = "Please Enter Mobile No.")]
        //[StringLength(12)]
        //public string MobileNo { get; set; }
    }
}
