using APBDProject.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Observed> Observations { get; set; }
        public DbSet<Ticker> Tickers { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Ticker>(t =>
            {
                t.HasKey(e => e.ticker);
            });
            builder.Entity<Observed>(o =>
            {
                o.HasKey(e => e.ObservationId);
                o.HasOne(e => e.User).WithMany(e => e.ObservedTickers).HasForeignKey(e => e.UserId);
                o.HasOne(e => e.Ticker).WithMany(e => e.Users).HasForeignKey(e => e.TickerName);
            });
        }
    }
}
