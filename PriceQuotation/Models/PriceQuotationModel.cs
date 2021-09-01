using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    //It takes input from the view sent by controller and calculates before sendig it back.
    public class PriceQuotationModel
    {
        [Required(ErrorMessage =
        "Please enter a Subtotal.")]
        [Range(1, double.PositiveInfinity, ErrorMessage =
        "Subtotal amount must be more than 0.")]
        public double? Subtotal { get; set; }

        [Required(ErrorMessage =
        "Please enter a Discount Percentage.")]
        [Range(0.1, 100.0, ErrorMessage =
        "Yearly interest rate must be between 0.1 and 100.")]
        public double? DiscountPercent { get; set; }
        public double? CalculatePriceQuotation()
        {

            double? DiscountAmount = Subtotal * (DiscountPercent * 0.01);

            double? Total = Subtotal - DiscountAmount;

            return Total;
        }
        public double? CalculateDiscountAmount()
        {

            double? DiscountAmount = Subtotal * (DiscountPercent * 0.01);

            return DiscountAmount;
        }


    }
}