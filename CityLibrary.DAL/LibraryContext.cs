﻿using CityLibrary.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CityLibrary.DAL
{
    public class LibraryContext : DbContext
    {
        public DbSet<LibraryUser> LibraryUsers { get; set; }
        public DbSet<BookCollection> BookCollections { get; set; }
        public DbSet<Book> LibraryBooks { get; set; }

        public LibraryContext() : base("ExternalDB")
        {
            //Database.SetInitializer<LibraryContext>(new LibraryInitializer());
        }
    }
}