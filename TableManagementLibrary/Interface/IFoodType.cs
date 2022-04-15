using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManagementLibrary.Models;

namespace TableManagementLibrary.Interface
{
   public interface IFoodType
    {
        /// <summary>
        /// get food type list
        /// </summary>
        /// <returns></returns>
         Task<IList<foodType>> GetFoodTypeList();

        /// <summary>
        /// get food type by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Task<foodType> GetFoodTypeById(int id);

        /// <summary>
        /// create record
        /// </summary>
        /// <param name="foodType"></param>
        /// <returns></returns>
        Task<bool> CreateAsync(foodType foodType);

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="foodType"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(foodType foodType);

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="foodType"></param>
        /// <returns></returns>
        Task<bool> DeleteAsysn(foodType foodType);

        /// <summary>
        /// record exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool foodTypeExists(int id);



    }
}
