using System.ComponentModel.DataAnnotations;
using WaveCafe.Models.Base;

namespace WaveCafe.Models
{
    public class Product : BaseEntity
    {
        [Required,StringLength(12,ErrorMessage ="max 12 element daxil olunmalidir"),MinLength(3,ErrorMessage ="minimum 3 element daxil olunmalidir")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<ProductImg>? productImgs { get; set; }
    }
}
