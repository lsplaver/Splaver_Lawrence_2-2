using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter the cost of the meal.")]
        [Range(0.01, 99999999999999999999.99, ErrorMessage = "Cost of the meal must be greater than 0.")]
        public decimal? CostOfMeal { get; set; }
        public decimal? CalculateTip15()
        {
            decimal? tipPercent = (decimal?)(15.00 / 100.00),  totalTip15 = 0;
            totalTip15 = CostOfMeal * tipPercent;
            return totalTip15;
        }
        public decimal? CalculateTip20()
        {
            decimal? tipPercent = (decimal?)(20.00 / 100.00), totalTip20 = 0;
            totalTip20 = CostOfMeal * tipPercent;
            return totalTip20;
        }
        public decimal? CalculateTip25()
        {
            decimal? tipPercent = (decimal?)(25.00 / 100.00), totalTip25 = 0;
            totalTip25 = CostOfMeal * tipPercent;
            return totalTip25;
        }
    }
}
