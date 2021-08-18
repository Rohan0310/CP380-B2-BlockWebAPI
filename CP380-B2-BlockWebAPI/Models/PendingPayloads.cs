using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CP380_B2_BlockWebAPI.Models
{
    public class PendingPayloads : DbContext
    {
        // TODO
        public PendingPayloads(DbContextOptions options) : base(options) {  }

       public DbSet<BlockSummary> blockSummaries;

    }
}
