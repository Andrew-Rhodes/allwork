using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding102.Models
{
    public class PerosnVM
    {
        public Person Person { get; set; }
        public List<SelectListItem> StateList { get; set; }

        public PerosnVM()
        {
            StateList = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "OH", Value = "Ohio"},
                new SelectListItem() {Text = "MI", Value = "Michigan"},
                new SelectListItem() {Text = "NJ", Value = "New Jersey"},
                new SelectListItem() {Text = "AK", Value = "Alaska"}
            };
        }
    }
}