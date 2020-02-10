using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDeliveryUI.Models
{
    public static class MethodExtense
    {
        public static bool IsStringEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        public static bool ValidateNumber(this int value)
        {
            return  value.ToString().Length == 10?true:false;
        }
    }
}
