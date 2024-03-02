using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Car : Entity<Guid>
{
    public string Name{ get; set; }
    public int ColorId { get; set; }
    public Guid ModelId { get; set; }
    public int CarState { get; set; }
    public int Kilometer { get; set; }
    public int ModelYear { get; set; }
    public string Plate { get; set; }
}
