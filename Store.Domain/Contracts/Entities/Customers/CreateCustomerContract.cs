using Flunt.Validations;
using Store.Domain.Entities;

namespace Store.Domain.Contracts.Entities.Customers
{
    public class CreateCustomerContract : Contract<Customer>
    {
        public CreateCustomerContract(Customer customer)
        {
            Requires()
                .IsNotNullOrEmpty(customer.Name, "Name", "Nome inválido")
                .IsEmail(customer.Email, "Email", "Email inválido");
        }
    }
}
