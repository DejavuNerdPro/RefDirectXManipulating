using RefDirecXManipulate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefDirecXManipulate.Data
{
    public class ProductService : IProductService
    {
        private readonly DataContext dataContext;
        public ProductService(DataContext context)
        {
            this.dataContext = context;
        }
        public List<Product> getAllproducts()
        {
            return dataContext.Product.ToList();
        }

        public int addProduct(Product product)
        {
           dataContext.Product.Add(product);
           return dataContext.SaveChanges();
        }

        public int removeProduct(Product product)
        {
            dataContext.Product.Remove(product);
            return dataContext.SaveChanges();
        }

        public int updateProduct(Product product)
        {
            Product existingProduct = dataContext.Product.Find(product.Pid);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Discount = product.Discount;

                return dataContext.SaveChanges();
            }
            else
            {
                return 5;  //product is existing
            }
        }
    }
}
