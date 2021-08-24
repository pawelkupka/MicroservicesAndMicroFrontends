using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Delivery.Api.Controllers
{
    using Application.Commands.CreateDelivery;
    using Application.Queries.GetDeliveryByOrderId;

    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DeliveriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{orderId}")]
        public async Task<GetDeliveryByOrderIdQueryResult> Get(Guid orderId)
        {
            return await _mediator.Send(new GetDeliveryByOrderIdQuery(orderId));
        }

        [HttpPost]
        public async Task Post([FromBody] CreateDeliveryCommand command)
        {
            await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
