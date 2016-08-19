using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ModelValidation.Models.Attributres;

namespace ModelValidation.Models
{
    public class Appointment
    {
        [Required]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Please enter a date")]
        [FutureDate]
        public DateTime Date { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "DO IT!!!")]
        [MustBeTrue(ErrorMessage = "DOOOOOOO IIITTTTTTTTTT!!!")]
        public bool TermsAccepted { get; set; }
    }
}