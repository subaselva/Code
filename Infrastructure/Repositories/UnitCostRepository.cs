using Domain.Entities;
using Infrastructure.Data;
using Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    // Infrastructure/Repositories/UnitCostRepository.cs
    public class UnitCostRepository : IUnitCostRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitCostRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UnitCost>> GetAllAsync()
        {
            // Fetch all records from the database
            return await _dbContext.UnitCosts.ToListAsync();
        }

        public async Task AddAsync(UnitCost unitCost)
        {
            // Add a new record to the database
            await _dbContext.UnitCosts.AddAsync(unitCost);
            await _dbContext.SaveChangesAsync();
        }
    }


}
