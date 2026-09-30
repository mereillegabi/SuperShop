using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public int CityId { get; set; }

        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}