using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManagementLibrary.Models;

namespace TableManagementLibrary.Interface
{
   public interface IMeal
    {
        /// <summary>
        /// get meal list
        /// </summary>
        /// <returns></returns>
         Task<IList<meal>> GetMealList();

        /// <summary>
        /// get meal by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Task<meal> GetMealById(int id);

        /// <summary>
        /// create record
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        Task<bool> CreateAsync(meal meal);

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(meal meal);

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        Task<bool> DeleteAsysn(meal meal);

        /// <summary>
        /// record exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool mealExists(int id);



    }
}
