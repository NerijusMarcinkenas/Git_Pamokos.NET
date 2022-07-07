﻿using FileReader.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.DataAccess
{
    internal class FileContext : DbContext
    {
        public DbSet<LocalFile> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
           options.UseSqlServer(@"Data Source = N-LENOVO\SQLEXPRESS; Initial Catalog = FilesDb; Integrated Security = True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalFile>().Property(x => x.Id).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Folder>().Property(x => x.Id).HasDefaultValueSql("newid()");
        }
    }

}
