using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAst2.Data;

namespace WebAppAst2.Data.Context
{
    public class StoreContext

         : DbContext
    {

        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {

        }
        public DbSet<Todo> ToDo { get; set; }
    }
}
