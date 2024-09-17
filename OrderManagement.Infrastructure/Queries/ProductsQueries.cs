using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Queries
{
    public static class ProductsQueries
    {
        public static QueryModel GetProductsQuery()
        {
            var table = Map.ContextMapping.GetProductsTable();
            var query = @$"
                SELECT 
                	[ProductID] AS ProductId,
                	[ProductName] AS ProductName,
                	[Description] AS Description,
                	[Price] AS Price,
                	[StockQuantity] AS StockQuantity,
                	[CreatedAt] AS CreatedAt
                FROM {table} WITH(NOLOCK)
            ";

            var parameters = new { };

            return new QueryModel(query, parameters);

        }
        public static QueryModel GetProductsById(long Id)
        {
            var table = Map.ContextMapping.GetProductsTable();
            var query = @$"
                SELECT 
        	        [ProductID] AS ProductId,
        	        [ProductName] AS ProductName,
        	        [Description] AS Description,
        	        [Price] AS Price,
        	        [StockQuantity] AS StockQuantity,
        	        [CreatedAt] AS CreatedAt
                FROM {table} WITH(NOLOCK)
                WHERE ProductID = @ProductId
            ";

            var parameters = new { 
            
                ProductId = Id

            };

            return new QueryModel(query, parameters);

        }
        public static QueryModel InserProducts(ProductsModel products)
        {
            var table = Map.ContextMapping.GetProductsTable();

            var query = $@"
            INSERT INTO {table} 
            (
            	ProductName, 
            	Description, 
            	Price, 
            	StockQuantity, 
            	CreatedAt
            )
            VALUES
            (
            	@ProductName,
                @Description,
                @Price,
                @StockQuantity,
                @CreatedAt
            )
            ";

            var parameters = new
            {
                products.ProductName,
                products.Description,
                products.Price,
                products.StockQuantity,
                products.CreatedAt

            };

            return new QueryModel(query, parameters);

        }

        public static QueryModel DeleteProducts(long Id)
        {
            var table = Map.ContextMapping.GetProductsTable();

            var query = $@"

            DELETE FROM {table} WHERE ProductID = @ProductID
            
            ";

            var parameters = new
            {
                ProductID = Id
            };

            return new QueryModel(query, parameters);

        }


    }
}
