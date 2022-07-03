using System.ComponentModel.DataAnnotations;

namespace tutorialProject.DTOs
{
    public class CountryDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " country name can not be empty")]
        // required mean that you can not send me information without this value 
        [StringLength(maximumLength: 50, ErrorMessage = "Counhtry name is very long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:5 , ErrorMessage = "Country shortName is very long")]
        public string ShortName { get; set; }
    }
    public class CreateCountryDTO
    {
       
    
        [Required]
        // required mean that you can not send me information without this value 
        [StringLength(maximumLength: 50, ErrorMessage = "Counhtry name is very long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 5, ErrorMessage = "Country shortName is very long")]
        public string ShortName { get; set; }
         public IList<HotelDTO> Hotels { get; set; }
    }
}
