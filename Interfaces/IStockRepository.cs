﻿using ApiFinShark.Dtos.Stocks;
using ApiFinShark.Helpers;
using ApiFinShark.Models;

namespace ApiFinShark.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock> UpdateAsync(int id, UpdateStockRequestDto stockDto );
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}
