using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TableManagementLibrary.Data;
using TableManagementLibrary.Models;

namespace TableManagementSystem.Pages.Admin.Booking
{
    public class IndexModel : PageModel
    {
        private readonly TableManagementLibrary.Data.ApplicationDbContext _context;

        public IndexModel(TableManagementLibrary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<bookingTable> bookingTable { get;set; }

        public async Task OnGetAsync()
        {
            bookingTable = await _context.BookingTable
                .Include(b => b.Flower)
                .Include(b => b.Meals)
                .Include(b => b.Table)
                 .Include(b => b.Type)
                .Include(b => b.TablePositions).ToListAsync();
        }
    }
}
