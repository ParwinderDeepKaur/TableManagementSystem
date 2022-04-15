using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableManagementLibrary.Interface;
using TableManagementLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TableManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablePositionController : ControllerBase
    {
        private readonly ITablePosition _tablePosition;
      
        public TablePositionController(ITablePosition tablePosition)
        {
            _tablePosition = tablePosition;
        }
        // GET: api/<TablePositionController>
        [HttpGet]
        public async Task <IList<tablePosition>> Get()
        {
            return await  _tablePosition.GetTablePositionList();
        }

        // GET api/<TablePositionController>/5
        [HttpGet("{id}")]
        public async Task<tablePosition> Get(int id)
        {
            var tablePosition = await _tablePosition.GetTablePositionById(id);

            return tablePosition;
        }

        // POST api/<TablePositionController>
        [HttpPost]
        public async Task<bool> Post([FromBody] tablePosition value)
        {
            

            bool result = false;
            try
            {
                result= await _tablePosition.CreateAsync(value);
                

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // PUT api/<TablePositionController>
        [HttpPut]
        public async Task<bool> Put([FromBody] tablePosition value)
        {

            bool result = false;
            try
            {
                tablePosition getRecord = await _tablePosition.GetTablePositionById(value.TablePositionId);
                if (getRecord != null)
                {
                    result = await _tablePosition.UpdateAsync(value);
                  
                }

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // DELETE api/<TablePositionController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            bool result = false;
            try
            {
                tablePosition getRecord = await _tablePosition.GetTablePositionById(id);
                if (getRecord != null)
                {
                    result= await _tablePosition.DeleteAsysn(getRecord);
                   
                }
                
            }
            catch (Exception)
            {

                result = false;
            }
          
            return result;
        }
    }
}
