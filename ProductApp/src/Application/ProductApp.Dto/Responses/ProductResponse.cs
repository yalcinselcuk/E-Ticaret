using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Dto.Responses
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty562/product/media/images/20221013/15/192857540/595610299/1/1_org_zoom.jpg";

        public double Price { get; set; }
    }
}
