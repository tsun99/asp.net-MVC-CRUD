using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netMVCCRUD.Models
{
    public class ImoneContext:DbContext
    {
        public ImoneContext(DbContextOptions<ImoneContext> options): base(options)
        {

        }
        public DbSet<Imone> Imones { get; set; }
    }
}
