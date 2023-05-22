using Store.Domain.Commands;

namespace Store.Tests.Commands
{
    [TestClass]
    public class CreateOrderCommandTests
    {
        [TestMethod]
        [TestCategory("Commands")]
        [DataRow("", "13411080")]
        [DataRow("AnaJoaoMarx", "123")]
        public void Dado_um_comando_invalido_o_pedido_nao_deve_ser_gerado(string customer, string zipCode)
        {
            var command = new CreateOrderCommand();
            command.Customer = customer;
            command.ZipCode = zipCode;
            command.PromoCode = "12345678";
            command.Items.Add(new CreateOrderItemCommand(Guid.NewGuid(), 1));
            command.Items.Add(new CreateOrderItemCommand(Guid.NewGuid(), 1));
            command.Validate();

            Assert.AreEqual(false, command.IsValid);
        }
    }
}
