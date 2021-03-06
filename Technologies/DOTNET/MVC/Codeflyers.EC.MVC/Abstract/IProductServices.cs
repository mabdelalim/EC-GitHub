﻿using System.Collections.Generic;
using Codeflyers.EC.Domain.Entities;

namespace Codeflyers.EC.MVC.Abstract
{
    public interface IProductServices
    {
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        Product GetProduct(int id);
        List<Product> GetAllProducts();
    }
}