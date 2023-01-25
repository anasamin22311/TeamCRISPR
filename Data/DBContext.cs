using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRISPR.Models;

    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<CRISPR.Models.DataSet> DataSet { get; set; } = default!;

        public DbSet<CRISPR.Models.Comment> Comment { get; set; }

        public DbSet<CRISPR.Models.GeneCode> GeneCode { get; set; }

        public DbSet<CRISPR.Models.Prop> Prop { get; set; }
    }
