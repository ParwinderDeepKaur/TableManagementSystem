using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TableManagementLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TableManagementLibrary.Interface;
using TableManagementLibrary.Data;

namespace TableManagementLibrary
{
    public class FoodTypeService : IFoodType
    {
        private readonly ApplicationDbContext _context;

        public FoodTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// get food type list
        /// </summary>
        /// <returns></returns>
        public async Task<IList<foodType>> GetFoodTypeList()
        {

           var type = await _context.FoodType.ToListAsync();

            return type;
        }

        /// <summary>
        /// get food type by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<foodType> GetFoodTypeById(int id)
        {
            return await _context.FoodType.FirstOrDefaultAsync(m => m.FoodId == id);
   
        }


        /// <summary>
        /// create food type record
        /// </summary>
        /// <param name="foodType"></param>
        /// <returns></returns>
          public async Task<bool> CreateAsync(foodType foodType)
        {
            _context.FoodType.Add(foodType);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="foodType"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(foodType foodType)
        {
            _context.Attach(foodType).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="foodType"></param>
        /// <returns></returns>
        public async Task<bool>  DeleteAsysn(foodType foodType)
        {
            _context.FoodType.Remove(foodType);
            await _context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// record exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool foodTypeExists(int id)
        {
            return _context.FoodType.Any(e => e.FoodId == id);
        }

    }
}
