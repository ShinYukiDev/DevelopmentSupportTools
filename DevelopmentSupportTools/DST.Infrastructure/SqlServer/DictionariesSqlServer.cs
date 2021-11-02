using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DST.Domain.Entities;
using DST.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DST.Infrastructure.SqlServer
{
    public class DictionariesSqlServer : IDictionariesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        /// <inheritdoc/>
        public DictionariesSqlServer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task<DictionaryEntity> CreateDictionary(DictionaryEntity dictionary)
        {
            var addedDictionary = _dbContext.Dictionaries.Add(dictionary);
            await _dbContext.SaveChangesAsync();
            return addedDictionary.Entity;
        }

        /// <inheritdoc/>
        public async Task<int> DeleteDictionary(int id)
        {
            var dbDictionary = await _dbContext.Dictionaries.FindAsync(id);
            if (dbDictionary == null)
            {
                return 0;
            }

            _dbContext.Dictionaries.Remove(dbDictionary);
            return await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<DictionaryEntity>> GetAllDictionaries()
        {
            try
            {
                return await _dbContext.Dictionaries.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<DictionaryEntity> GettDictionary(int id)
        {
            return await _dbContext.Dictionaries.FindAsync(id);
        }

        /// <inheritdoc/>
        public async Task<DictionaryEntity> UpdateDictionary(int id, DictionaryEntity dictionary)
        {
            if (id != dictionary.Id)
            {
                throw new Exception("パラメータのIDと辞書情報のIDが等しくないです。");
            }

            DictionaryEntity dbDictionary = await _dbContext.Dictionaries.FindAsync(id);
            if (dbDictionary == null)
            {
                throw new Exception("更新対象のデータが存在しません。");
            }

            var updatedDicitionary = _dbContext.Dictionaries.Update(dictionary);
            await _dbContext.SaveChangesAsync();
            return updatedDicitionary.Entity;
        }
    }
}