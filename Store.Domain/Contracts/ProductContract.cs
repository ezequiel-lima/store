using Flunt.Validations;
using Store.Domain.Entities;

namespace Store.Domain.Contracts
{
    public class ProductContract : Contract<Product>
    {
        public ProductContract(Product product)
        {
            Requires()
                .IsNotNull(product, "Product", "Produto inválido");
        }
    }
}
