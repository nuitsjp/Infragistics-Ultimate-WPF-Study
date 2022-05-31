using System.Collections.Generic;
using System.Linq;

namespace ThemeManagerStudy;

public class MainViewModel
{
    public IEnumerable<Customer> Customers { get; } = Enumerable.Range(1, 10).Select(x => new Customer());
}

public class Customer
{
    public string FirstName { get; } = Faker.Name.First();
    public string LastName { get; } = Faker.Name.Last();
    public string Address { get; } = Faker.Address.StreetAddress();
    public string City { get; } = Faker.Address.City();
}