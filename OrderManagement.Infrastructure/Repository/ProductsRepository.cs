using OrderManagement.Application.DTOs;
using OrderManagement.Application.Repositories;
using OrderManagement.Domain.Entities;
using OrderManagement.Infrastructure.Factory;
using System.Data;
using Dapper;
using OrderManagement.Infrastructure.Queries;
using System.Xml.Linq;

namespace OrderManagement.Infrastructure.Repository
{
    public class ProductsRepository(SqlFactory factory) : IProductsRepository
    {
        private readonly IDbConnection _connection = factory.CreateConnection();


        public async Task<IEnumerable<ProductsDTO>> GetAllProducts()
        {
            var query = ProductsQueries.GetProductsQuery();
            var products = await _connection.QueryAsync<ProductsDTO>(query.Query, query.Parameters);
            return products;
        }

        public async Task<ProductsDTO> GetProductsById(long Id)
        {
            var query = ProductsQueries.GetProductsById(Id);
            var product = await _connection.QueryFirstOrDefaultAsync<ProductsDTO>(query.Query, query.Parameters);
            return product;
        }

        public async void InsertProducts(ProductsModel products)
        {
            var query = ProductsQueries.InserProducts(products);
            await _connection.ExecuteAsync(query.Query, query.Parameters);
            
        }
    }
}

