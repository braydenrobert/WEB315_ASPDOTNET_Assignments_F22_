using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BraydensTravelJournal.Data;
using BraydensTravelJournal.Models;
using NuGet.Protocol.Core.Types;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BraydensTravelJournal.Pages.Journals
{
    public class IndexModel : PageModel
    {
        private readonly BraydensTravelJournal.Data.BraydensTravelJournalContext _context;

        public IndexModel(BraydensTravelJournal.Data.BraydensTravelJournalContext context)
        {
            _context = context;
        }

        public IList<Journal> Journal { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int IntegerSort { get; set; }
        public string FilterOne { get; set; }
        public string FilterTwo { get; set; }
        public string FilterThree { get; set; }

        public async Task OnGetAsync(int sortOrder, string searchName, string searchDescription, string searchAddress)
        {

            FilterOne = searchName;
            FilterTwo = searchDescription;
            FilterThree = searchAddress;

            var search = from a in _context.Journal
                         select a;
            var description = from b in _context.Journal
                                            select b;
            var address = from c in _context.Journal
                                             select c;

            if (_context.Journal != null)
            {
                Journal = await _context.Journal.ToListAsync();
            }
            if (!string.IsNullOrEmpty(searchName))
            {
                search = search.Where(a => a.Name == FilterOne);
            }
            if (!string.IsNullOrEmpty(searchDescription))
            {
                search = search.Where(b => b.Description == FilterTwo);
            }
            if (!string.IsNullOrEmpty(searchAddress))
            {
                search = search.Where(c => c.address == FilterThree);
            }
            Journal = await search.AsNoTracking().ToListAsync();
            Journal = await address.ToListAsync();
            Journal = await description.ToListAsync();
        }
    }
}
