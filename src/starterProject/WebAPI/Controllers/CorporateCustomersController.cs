using Application.Features.CorporateCustomers.Commands.Create;
using Application.Features.CorporateCustomers.Queries.GetList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CorporateCustomersController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCorporateCustomerCommand command)
    {
        CreatedCorporateCustomerResponse response = await Mediator.Send(command);
        return Created("", response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        GetListCorporateCustomerQuery query = new GetListCorporateCustomerQuery() { PageRequest = pageRequest };
        GetListResponse<GetListCorporateCustomerItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
