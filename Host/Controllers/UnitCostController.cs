using Application.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    // WebAPI/Controllers/UnitCostController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class UnitCostController : ControllerBase
    {
        private readonly IUnitCostService _unitCostService;

        public UnitCostController(IUnitCostService unitCostService)
        {
            _unitCostService = unitCostService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var unitCosts = await _unitCostService.GetAllUnitCostsAsync();
            return Ok(unitCosts);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UnitCost unitCost)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _unitCostService.AddUnitCostAsync(unitCost);
            return CreatedAtAction(nameof(GetAll), new { id = unitCost.UnitCodeArea }, unitCost);
        }
    }

}
