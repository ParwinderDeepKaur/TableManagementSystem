using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TableManagementLibrary.Data;
using TableManagementLibrary.Models;

namespace TableManagementSystem.Pages.Admin.Booking
{
    public class EditModel : PageModel
    {
        private readonly TableManagementLibrary.Data.ApplicationDbContext _context;

        public EditModel(TableManagementLibrary.Data.ApplicationDbContext context)
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
                .Include(b=>b.Type)
                .Include(b => b.TablePositions).FirstOrDefaultAsync(m => m.Id == id);

            if (bookingTable == null)
            {
                return NotFound();
            }
           ViewData["FlowerId"] = new SelectList(_context.Flowers, "FlowerId", "Name");
           ViewData["MealId"] = new SelectList(_context.Meal, "MealId", "Name");
           ViewData["TableId"] = new SelectList(_context.Tables, "TableId", "TableName");
            ViewData["FoodId"] = new SelectList(_context.FoodType, "FoodId", "Name");
            ViewData["TablePositionId"] = new SelectList(_context.tablePosition, "TablePositionId", "Position");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(bookingTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!bookingTableExists(bookingTable.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool bookingTableExists(int id)
        {
            return _context.BookingTable.Any(e => e.Id == id);
        }
    }
}
