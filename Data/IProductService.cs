using RefDirecXManipulate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefDirecXManipulate.Data
{
    interface IProductService
    {
        public List<Product> getAllproducts();
        public int addProduct(Product product);
        public int removeProduct(Product product);
        public int updateProduct(Product product);
    }
}
