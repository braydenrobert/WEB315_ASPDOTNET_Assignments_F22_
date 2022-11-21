using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BraydensTravelJournal.Data;
using BraydensTravelJournal.Models;

namespace BraydensTravelJournal.Pages.Journals
{
    public class DeleteModel : PageModel
    {
        private readonly BraydensTravelJournal.Data.BraydensTravelJournalContext _context;

        public DeleteModel(BraydensTravelJournal.Data.BraydensTravelJournalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Journal Journal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Journal == null)
            {
                return NotFound();
            }

            var journal = await _context.Journal.FirstOrDefaultAsync(m => m.Id == id);

            if (journal == null)
            {
                return NotFound();
            }
            else 
            {
                Journal = journal;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Journal == null)
            {
                return NotFound();
            }
            var journal = await _context.Journal.FindAsync(id);

            if (journal != null)
            {
                Journal = journal;
                _context.Journal.Remove(Journal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
