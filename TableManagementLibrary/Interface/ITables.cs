using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManagementLibrary.Models;

namespace TableManagementLibrary.Interface
{
   public interface ITables
    {
        /// <summary>
        /// table list
        /// </summary>
        /// <returns></returns>
         Task<IList<tables>> GetTableList();

        /// <summary>
        /// get record by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Task<tables> GetTableById(int? id);

        /// <summary>
        /// create record 
        /// </summary>
        /// <param name="tables"></param>
        /// <returns></returns>

        Task<bool> CreateAsync(tables tables);

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="tables"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(tables tables);

        /// <summary>
        /// delete records
        /// </summary>
        /// <param name="tables"></param>
        /// <returns></returns>
        Task<bool> DeleteAsysn(tables tables);

        /// <summary>
        /// record exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool tableExists(int id);



    }
}
