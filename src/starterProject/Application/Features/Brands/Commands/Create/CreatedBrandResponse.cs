
namespace Application.Features.Brands.Commands.Create;
public class CreatedBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public bool Premium { get; set; }
    public double Rating { get; set; }
}
