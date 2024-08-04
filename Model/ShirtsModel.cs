using System.ComponentModel.DataAnnotations;
using WebAPI_Demo.Model.Validation;

namespace WebAPI_Demo.Model
{
    public class ShirtsModel
    {
       
        public int shirtId { get; set; }
        
        public string? Brand { get; set; }
        public string? Color { get; set; }

        [Required]
        public string? gender { get; set; }

        [Shirt__EnsureCorrectSizing]
        public int? size { get; set; }   

    }
}
