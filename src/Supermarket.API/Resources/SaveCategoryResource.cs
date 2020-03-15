using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
    public class SaveCategoryResource
    {
        /*These attributes are called Data Annotation */
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}