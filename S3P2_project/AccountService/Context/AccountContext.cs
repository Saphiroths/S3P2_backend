﻿using AccountService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountService.Context
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountPost> AccountPosts { get; set; }

    }
}
