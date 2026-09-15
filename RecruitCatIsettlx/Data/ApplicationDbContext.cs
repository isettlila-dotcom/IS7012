using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AccountHolder> AccountHolder { get; set; } = default!;

public DbSet<BankAccount> BankAccount { get; set; } = default!;

public DbSet<Candidate> Candidate { get; set; } = default!;

public DbSet<Company> Company { get; set; } = default!;

public DbSet<Industry> Industry { get; set; } = default!;

public DbSet<JobTitle> JobTitle { get; set; } = default!;
    }
