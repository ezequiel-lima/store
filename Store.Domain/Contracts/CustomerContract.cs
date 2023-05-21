using Flunt.Validations;
using Store.Domain.Entities;

namespace Store.Domain.Contracts
{
    public class CustomerContract : Contract<Customer>
    {
        public CustomerContract(Customer customer)
        {
            Requires()
                .IsNotNull(customer, "Customer", "Cliente inválido");
        }
    }
}
