using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models.Attributres
{
    public class MustBeTrueAttribute : ValidationAttribute
    {
        public override bool IsValid(Object value)
        {
            bool valid = true;
            valid = (value is bool && (bool) value == true);
            return valid;
        }
    }
}