using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing01.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(50, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name Is Too Long")]
        public string ShortName { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }
    }
}
