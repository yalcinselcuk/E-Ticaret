﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty562/product/media/images/20221013/15/192857540/595610299/1/1_org_zoom.jpg";
        
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public byte? Rating { get; set; }
        public Category? Category { get; set; }
    }
}
