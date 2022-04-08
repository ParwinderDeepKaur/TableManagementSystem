using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManagementLibrary.Models;

namespace TableManagementLibrary.Interface
{
   public interface ITablePosition
    {
        /// <summary>
        /// get table position list
        /// </summary>
        /// <returns></returns>
         Task<IList<tablePosition>> GetTablePositionList();

        /// <summary>
        /// get record by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Task<tablePosition> GetTablePositionById(int? id);

        /// <summary>
        /// create record
        /// </summary>
        /// <param name="tables"></param>
        /// <returns></returns>
        Task<bool> CreateAsync(tablePosition tables);

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="tables"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(tablePosition tables);

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="tables"></param>
        /// <returns></returns>
        Task<bool> DeleteAsysn(tablePosition tables);

        /// <summary>
        /// record exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool tablePositisonExists(int id);



    }
}
