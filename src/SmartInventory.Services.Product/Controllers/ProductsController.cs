using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartInventory.Services.Product.DTOs;
using SmartInventory.Services.Product.Features.Products.Commands;
using SmartInventory.Services.Product.Features.Products.Queries;

namespace SmartInventory.Services.Product.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<List<ProductDto>>>> GetProducts()
        {
            var result = await _mediator.Send(new GetProductsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<Guid>>> CreateProduct(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProducts), new { id = result.Data }, result);
        }
    }
}
