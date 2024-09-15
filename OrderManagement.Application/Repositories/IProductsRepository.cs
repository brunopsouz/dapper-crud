using OrderManagement.Application.DTOs;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Repositories
{
    public interface IProductsRepository
    {
        Task<IEnumerable<ProductsDTO>> GetAllProducts();
        Task<ProductsDTO> GetProductsById(long Id);
        void InsertProducts(ProductsModel products);
    }
}
