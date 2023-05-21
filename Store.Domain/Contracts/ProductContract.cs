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

        public ProductContract(Product product, int quantity)
        {
            Requires()
                .IsNotNull(product, "Product", "Produto inválido")
                .IsGreaterThan(quantity, 0, "A quantidade deve ser maior que zero");
        }
    }
}
