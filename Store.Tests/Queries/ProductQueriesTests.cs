using Store.Domain.Entities;
using Store.Domain.Queries.Products;

namespace Store.Tests.Queries
{
    [TestClass]
    public class ProductQueriesTests
    {
        private IList<Product> _products;

        public ProductQueriesTests()
        {
            _products = new List<Product>();
            _products.Add(new("Produto 1", 10, true));
            _products.Add(new("Produto 2", 60, true));
            _products.Add(new("Produto 3", 50, true));
            _products.Add(new("Produto 4", 10, true));
            _products.Add(new("Produto 5", 20, false));
            _products.Add(new("Produto 6", 10, false));
        }

        [TestMethod]
        [TestCategory("Queries")]
        public void Dado_a_consulta_de_produtos_ativos_deve_retornar_4()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());
            Assert.AreEqual(4, result.Count());
        }

        [TestMethod]
        [TestCategory("Queries")]
        public void Dado_a_consulta_de_produtos_inativos_deve_retornar_2()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());
            Assert.AreEqual(2, result.Count());
        }
    }
}
