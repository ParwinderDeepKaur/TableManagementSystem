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
    public class BookingService: IBooking
    {
        private readonly ApplicationDbContext _context;

        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// get booking list
        /// </summary>
        /// <returns></returns>
        public async Task<IList<bookingTable>> GetBookingList()
        {

           var booking = await _context.BookingTable.ToListAsync();

            return booking;
        }

        /// <summary>
        /// get booking by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bookingTable> GetBookingById(int id)
        {
            return await _context.BookingTable.FirstOrDefaultAsync(m => m.Id == id);
   
        }


        /// <summary>
        /// create booking record
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
          public async Task<bool> CreateAsync(bookingTable booking)
        {
            _context.BookingTable.Add(booking);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(bookingTable booking)
        {
            _context.Attach(booking).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public async Task<bool>  DeleteAsysn(bookingTable booking)
        {
            _context.BookingTable.Remove(booking);
            await _context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// record exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool bookingExists(int id)
        {
            return _context.BookingTable.Any(e => e.Id == id);
        }

    }
}
