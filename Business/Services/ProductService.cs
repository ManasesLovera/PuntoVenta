using Business.Interfaces.Repositories;
using Data.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Business.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository productRepository)
        {
            _repository = productRepository;
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _repository.GetAllAsync();
        }
    }
}
