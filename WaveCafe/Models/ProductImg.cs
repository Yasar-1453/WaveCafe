using WaveCafe.Models.Base;

namespace WaveCafe.Models
{
    public class ProductImg : BaseEntity
    {
        public string ImgUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
