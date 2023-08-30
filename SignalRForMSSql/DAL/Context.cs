﻿using Microsoft.EntityFrameworkCore;

namespace Traversal.SignalRForMSSql.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
