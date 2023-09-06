
namespace design_patterns.Command
{
    internal class AddCustomerCommand : design_patterns.Command.fx.Command
    {
        private CustomerService customerService;
        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }
        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}
