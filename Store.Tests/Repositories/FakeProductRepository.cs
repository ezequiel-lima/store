using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Get(IEnumerable<Guid> ids)
        {
            Product product3 = new Product { Id = Guid.Parse("021180e2-f0bb-4c66-9ba5-703aa5cd0355") };
            product3.Alterar("Produto 3", 50, true);
            Product product4 = new Product { Id = Guid.Parse("b701b8fd-b173-43c6-a7bc-a3a33b783f91") };
            product4.Alterar("Produto 4", 10, true);

            IList<Product> products = new List<Product>();
            products.Add(new("Produto 1", 10, true));
            products.Add(new("Produto 2", 60, true));
            products.Add(product3);
            products.Add(product4);
            products.Add(new("Produto 5", 20, false));
            products.Add(new("Produto 6", 10, false));

            return products;
        }
    }
}
