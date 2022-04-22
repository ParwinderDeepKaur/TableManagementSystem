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
    public class BookingController : ControllerBase
    {
        private readonly IBooking _booking;
      
        public BookingController(IBooking booking)
        {
            _booking = booking;
        }
        // GET: api/<BookingController>
        [HttpGet]
        public async Task <IList<bookingTable>> Get()
        {
            return await  _booking.GetBookingList();
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public async Task<bookingTable> Get(int id)
        {
            var bookingTable = await _booking.GetBookingById(id);

            return bookingTable;
        }

        // POST api/<BookingController>
        [HttpPost]
        public async Task<bool> Post([FromBody] bookingTable value)
        {
            

            bool result = false;
            try
            {
                result= await _booking.CreateAsync(value);
                

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // PUT api/<BookingController>
        [HttpPut]
        public async Task<bool> Put([FromBody] bookingTable value)
        {

            bool result = false;
            try
            {
                bookingTable getRecord = await _booking.GetBookingById(value.MealId);
                if (getRecord != null)
                {
                    result = await _booking.UpdateAsync(value);
                  
                }

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            bool result = false;
            try
            {
                bookingTable getRecord = await _booking.GetBookingById(id);
                if (getRecord != null)
                {
                    result= await _booking.DeleteAsysn(getRecord);
                   
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
