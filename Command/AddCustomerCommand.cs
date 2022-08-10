using DesignPatterns.Command.fx;

namespace DesignPatterns.Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            this._service = service;
        }

        public void Execute()
        {
            this._service.AddCustomer();
        }
    }
}