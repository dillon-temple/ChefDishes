using System;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ChefDishes.Models{

    public static class AgeCalc{
        public static string Age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age.ToString();
        }
    }

}

