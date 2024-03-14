using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Model : Entity<Guid>
{
    public Guid BrandId { get; set; }
    public Guid FuelId { get; set; }
    public Guid TransmissionId { get; set; }
    public string Name { get; set; }
    public double DailyPrice { get; set; }
    public short Year { get; set; }
    public virtual Brand? Brand { get; set; } = null; 
    public virtual Fuel? Fuel { get; set; } = null;
    public virtual Transmission? Transmission { get; set; } = null;
}
