using System.ComponentModel.DataAnnotations;

namespace HCPriceApplication.Models
{
    public class Quotation
    {
        [Required(ErrorMessage = "Please enter a Subtotal.")]
        [Range(0.01, 99999999, ErrorMessage = "Subtotal must be greater than 0")]
        public decimal? Subtotal { get; set; } // subtotal declaration, must be over 0

        [Required(ErrorMessage = "Please enter a Discount.")]
        [Range(0, 100, ErrorMessage =
               "Discount percent must be between 0 and 100")]
        public decimal? Discount { get; set; } // discount declaration, must be between 0 and 100

        public decimal? CalculateDiscount() // method to calculate discount
        {
            decimal? discountAmount = Subtotal * (Discount / 100); // calculation
            return discountAmount; // return value
        }

        public decimal? CalculateTotal() // method to calculate total
        {
            decimal? total = Subtotal - ((Discount / 100) * Subtotal); // calculation
            return total; // return value
        }
    }
}
