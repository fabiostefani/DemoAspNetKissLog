using System;
using System.Threading.Tasks;
using DemoAspNetKissLog.Dtos;
using DemoAspNetKissLog.Model;
using DemoAspNetKissLog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DemoAspNetKissLog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]        
        public async Task<IActionResult> Get()
        {
            return Ok(await _orderRepository.GetAll());
        }

        [HttpGet]
        [Route("Get/{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _orderRepository.GetById(id));
        }

        [HttpPost]        
        public async Task<IActionResult> Post([FromBody] CreateOrderDto orderDto)
        {
            var order = new Order(orderDto.Total, orderDto.Taxes, orderDto.IssueDate, orderDto.Sequence);
            await _orderRepository.Save(order);
            return Created(nameof(GetById), order.Id);
        }
    }
}