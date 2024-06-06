using DehasoftOne.Data.Customers;
using DehasoftOne.Entity.Customer;

namespace DehasoftOne.Business.Customers;

public class CustomerService : ICustomerService
{
    private readonly CustomerRepository _customerRepository;
    public CustomerService(CustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<Customer> AddCustomer(Customer customer)
    {
        return await _customerRepository.AddAsync(customer);
    }

    public async Task UpdateCustomer(Customer customer)
    {
        await _customerRepository.UpdateAsync(customer);
    }

    public async Task DeleteCustomer(Guid id)
    {
        await _customerRepository.DeleteAsync(id);
    }
    public async Task<List<Customer>> GetCustomers()
    {
        return _customerRepository.GetAll().ToList();
    }

    public async Task<Customer> GetCustomer(Guid id)
    {
        return await _customerRepository.GetByIdAsync(id);
    }
}
