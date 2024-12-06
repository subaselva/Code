using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    
        // Application/Interfaces/IUnitCostRepository.cs
        public interface IUnitCostRepository
        {
            Task<List<UnitCost>> GetAllAsync(); // Fetch all Unit Costs
            Task AddAsync(UnitCost unitCost);  // Add a new Unit Cost
        }

    
}
