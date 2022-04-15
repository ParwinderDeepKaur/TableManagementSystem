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
    public class GuestController : ControllerBase
    {
        private readonly IGuest _guest;
      
        public GuestController(IGuest guest)
        {
            _guest = guest;
        }
        // GET: api/<GuestController>
        [HttpGet]
        public async Task <IList<guest>> Get()
        {
            return await  _guest.GetGuestList();
        }

        // GET api/<GuestController>/5
        [HttpGet("{id}")]
        public async Task<guest> Get(int id)
        {
            var meal = await _guest.GetGuestById(id);

            return meal;
        }

        // POST api/<GuestController>
        [HttpPost]
        public async Task<bool> Post([FromBody] guest value)
        {
            

            bool result = false;
            try
            {
                result= await _guest.CreateAsync(value);
                

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // PUT api/<GuestController>
        [HttpPut]
        public async Task<bool> Put([FromBody] guest value)
        {

            bool result = false;
            try
            {
                guest getRecord = await _guest.GetGuestById(value.GuestId);
                if (getRecord != null)
                {
                    result = await _guest.UpdateAsync(value);
                  
                }

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // DELETE api/<GuestController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            bool result = false;
            try
            {
                guest getRecord = await _guest.GetGuestById(id);
                if (getRecord != null)
                {
                    result= await _guest.DeleteAsysn(getRecord);
                   
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
