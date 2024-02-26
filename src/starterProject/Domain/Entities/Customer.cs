using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Customer : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public IndividualCustomer? IndividualCustomer { get; set; } = null;
    public CorporateCustomer? CorporateCustomer { get; set; } = null;
    public int IndividualCustomerId { get; set; }
    public int CorporateCustomerId { get; set; }
}
