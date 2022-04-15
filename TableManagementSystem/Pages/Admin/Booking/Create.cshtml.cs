using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TableManagementLibrary.Data;
using TableManagementLibrary.Models;

namespace TableManagementSystem.Pages.Admin.Booking
{
    public class CreateModel : PageModel
    {
        private readonly TableManagementLibrary.Data.ApplicationDbContext _context;

        public CreateModel(TableManagementLibrary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FlowerId"] = new SelectList(_context.Flowers, "FlowerId", "Name");
        ViewData["MealId"] = new SelectList(_context.Meal, "MealId", "Name");
        ViewData["TableId"] = new SelectList(_context.Tables, "TableId", "TableName");
            ViewData["FoodId"] = new SelectList(_context.FoodType, "FoodId", "Name");
            ViewData["TablePositionId"] = new SelectList(_context.tablePosition, "TablePositionId", "Position");
            return Page();
        }

        [BindProperty]
        public bookingTable bookingTable { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookingTable.Add(bookingTable);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
