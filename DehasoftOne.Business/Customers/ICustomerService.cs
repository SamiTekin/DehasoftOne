using DehasoftOne.Entity.Customer;

namespace DehasoftOne.Business.Customers
{
    public interface ICustomerService
    {
        Task<Customer> AddCustomer(Customer customer);
        Task DeleteCustomer(Guid id);
        Task<Customer> GetCustomer(Guid id);
        Task<List<Customer>> GetCustomers();
        Task UpdateCustomer(Customer customer);
    }
}