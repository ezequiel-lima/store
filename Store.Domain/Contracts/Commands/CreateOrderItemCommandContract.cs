using Flunt.Validations;
using Store.Domain.Commands;

namespace Store.Domain.Contracts.Commands
{
    public class CreateOrderItemCommandContract : Contract<CreateOrderItemCommand>
    {
        public CreateOrderItemCommandContract(CreateOrderItemCommand createOrderItemCommand)
        {
            Requires()
                .IsNotUrlOrEmpty(createOrderItemCommand.ProductId.ToString(), "ProductId", "Produto inválido")
                .IsGreaterThan(createOrderItemCommand.Quantity, 0, "A quantidade deve ser maior que zero");
        }
    }
}
