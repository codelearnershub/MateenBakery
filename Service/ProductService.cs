using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using System;

namespace BakeryManagementSystem.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Add(Product product)
        {
            product = new Product
            {
                CreatedAt = DateTime.Now,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice,
                ProductAvailability = product.ProductAvailability
            };

            return _productRepository.Add(product);
        }


        public Product FindById(int id)
        {
            return _productRepository.FindById(id);
        }

        public Product Update(int ProductId, Product product)
        {
            product = _productRepository.FindById(ProductId);
            if (product == null)
            {
                return null;
            }

            product.ProductDescription = product.ProductDescription;
            product.ProductPrice = product.ProductPrice;
            product.ProductAvailability = product.ProductAvailability;
            product.UpdatedAt = DateTime.Now;

            return _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }
    }
}