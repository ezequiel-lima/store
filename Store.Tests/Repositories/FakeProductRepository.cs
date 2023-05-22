using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Get(IEnumerable<Guid> ids)
        {
            IList<Product> products = new List<Product>();
            products.Add(new("Produto 1", 10, true));
            products.Add(new("Produto 2", 60, true));
            products.Add(new("Produto 3", 50, true));
            products.Add(new("Produto 4", 10, true));
            products.Add(new("Produto 5", 20, false));
            products.Add(new("Produto 6", 10, false));

            return products;
        }
    }
}
