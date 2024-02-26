using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Model : Entity<Guid>
{
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public double DailyPrice { get; set; }
    public short Year { get; set; }
    public Brand? Brand { get; set; } = null;
    public Fuel? Fuel { get; set; } = null;
    public Transmission? Transmission { get; set; } = null;
}
