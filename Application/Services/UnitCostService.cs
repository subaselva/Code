using Application.Interface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    // Application/Services/UnitCostService.cs
    public class UnitCostService : IUnitCostService
    {
        private readonly IUnitCostRepository _repository;

        public UnitCostService(IUnitCostRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<UnitCost>> GetAllUnitCostsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddUnitCostAsync(UnitCost unitCost)
        {
            await _repository.AddAsync(unitCost);
        }
    }



}

