using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        //public override bool IsValid(object value)
        //{
        //    DateTime dateTime;
        //    var isValid = DateTime.TryParseExact(Convert.ToString(value),
        //        "dd/M/yyyy",
        //        CultureInfo.CurrentCulture,
        //        DateTimeStyle.None,
        //        out dateTime);
        //    return (isValid && dateTime > DateTime.Now);
        //}
    }
}