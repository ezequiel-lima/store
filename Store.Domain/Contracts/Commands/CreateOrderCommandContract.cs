using Flunt.Validations;
using Store.Domain.Commands;

namespace Store.Domain.Contracts.Commands
{
    public class CreateOrderCommandContract : Contract<CreateOrderCommand>
    {
        public CreateOrderCommandContract(CreateOrderCommand createOrderCommand)
        {
            Requires()
                .AreEquals(createOrderCommand.Customer, 11, "Customer", "Cliente inválido")
                .AreEquals(createOrderCommand.ZipCode, 8, "ZipCode", "CEP inválido");
        }
    }
}
