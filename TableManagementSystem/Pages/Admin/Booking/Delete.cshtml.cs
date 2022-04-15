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
    public class DeleteModel : PageModel
    {
        private readonly TableManagementLibrary.Data.ApplicationDbContext _context;

        public DeleteModel(TableManagementLibrary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public bookingTable bookingTable { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            bookingTable = await _context.BookingTable
                .Include(b => b.Flower)
                .Include(b => b.Meals)
                .Include(b => b.Table)
                .Include(b => b.TablePositions).FirstOrDefaultAsync(m => m.Id == id);

            if (bookingTable == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            bookingTable = await _context.BookingTable.FindAsync(id);

            if (bookingTable != null)
            {
                _context.BookingTable.Remove(bookingTable);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
