using Flunt.Notifications;
using Store.Domain.Commands.Interfaces;
using Store.Domain.Contracts.Commands;

namespace Store.Domain.Commands
{
    public class CreateOrderItemCommand : Notifiable<Notification>, ICommand
    {
        public CreateOrderItemCommand() { }

        public CreateOrderItemCommand(Guid productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }

        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        public void Validate()
        {
            AddNotifications(new CreateOrderItemCommandContract(this));
        }
    }
}
