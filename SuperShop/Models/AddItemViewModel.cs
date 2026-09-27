using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class AddItemViewModel
    {
        [Display(Name = "Product")]
        [Range(1,int.MaxValue, ErrorMessage = "You must select a product.")] //entre o item da posição 1 e o máximo de produtos, se não meter nada é considerado a posição 0 :select a product.
        public int ProductId { get; set; }

        [Range(0.0001, double.MaxValue, ErrorMessage = "Yhe quantity must be a positive number..")]
        public double Quantity { get; set; }

        public IEnumerable<SelectListItem> Products { get; set; }
    }
}
