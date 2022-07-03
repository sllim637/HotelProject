using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tutorialProject.Models;

namespace tutorialProject.DTOs
{
    public class CreateHotelDTO
    {
      
        [Required(ErrorMessage = "hotel name can not be empty")]
        [StringLength(maximumLength:50 , ErrorMessage = "the hotel name is very long")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }
}
