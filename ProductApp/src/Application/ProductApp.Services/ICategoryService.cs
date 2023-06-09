﻿using ProductApp.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDisplayResponse> GetCategoryDisplayResponses();
    }
}
