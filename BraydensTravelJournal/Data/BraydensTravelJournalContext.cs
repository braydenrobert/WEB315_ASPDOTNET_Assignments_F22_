using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BraydensTravelJournal.Models;

namespace BraydensTravelJournal.Data
{
    public class BraydensTravelJournalContext : DbContext
    {
        public BraydensTravelJournalContext (DbContextOptions<BraydensTravelJournalContext> options)
            : base(options)
        {
        }

        public DbSet<BraydensTravelJournal.Models.Journal> Journal { get; set; } = default!;
    }
}
