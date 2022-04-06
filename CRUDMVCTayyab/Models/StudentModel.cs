using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDMVCTayyab.Models
{
    public class StudentModel
    {
        [Display(Name = "ID")]
        public int StudentID { get; set; }

        [Required (ErrorMessage ="Name is Required")]
        public string StudentName { get; set; }

        [Required(ErrorMessage ="City is Required")]
        public string StudentCity { get; set; }

        [Required(ErrorMessage ="Address is Required")]
        public string StudentAdsress { get; set; }
    }
}