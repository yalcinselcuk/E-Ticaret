using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Dto.Requests
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün Adını Boş Bırakmayınız")]
        [MinLength(3, ErrorMessage = "En az 3 karakter")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty562/product/media/images/20221013/15/192857540/595610299/1/1_org_zoom.jpg";
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
        public byte? Rating { get; set; }
    }
}
