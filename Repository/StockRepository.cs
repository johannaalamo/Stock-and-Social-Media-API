using ApiFinShark.Data;
using ApiFinShark.Interfaces;
using ApiFinShark.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFinShark.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context) 
        {
            _context = context;  
        }
        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stocks.ToListAsync();

        }
    }
}
