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
    public class MealController : ControllerBase
    {
        private readonly IMeal _meal;
      
        public MealController(IMeal meal)
        {
            _meal = meal;
        }
        // GET: api/<MealController>
        [HttpGet]
        public async Task <IList<meal>> Get()
        {
            return await  _meal.GetMealList();
        }

        // GET api/<MealController>/5
        [HttpGet("{id}")]
        public async Task<meal> Get(int id)
        {
            var meal = await _meal.GetMealById(id);

            return meal;
        }

        // POST api/<MealController>
        [HttpPost]
        public async Task<bool> Post([FromBody] meal value)
        {
            

            bool result = false;
            try
            {
                result= await _meal.CreateAsync(value);
                

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // PUT api/<MealController>
        [HttpPut]
        public async Task<bool> Put([FromBody] meal value)
        {

            bool result = false;
            try
            {
                meal getRecord = await _meal.GetMealById(value.MealId);
                if (getRecord != null)
                {
                    result = await _meal.UpdateAsync(value);
                  
                }

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // DELETE api/<MealController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            bool result = false;
            try
            {
                meal getRecord = await _meal.GetMealById(id);
                if (getRecord != null)
                {
                    result= await _meal.DeleteAsysn(getRecord);
                   
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
