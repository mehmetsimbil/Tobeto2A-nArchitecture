using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Commands.Create;
public class CreatedCorporateCustomerResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
}
