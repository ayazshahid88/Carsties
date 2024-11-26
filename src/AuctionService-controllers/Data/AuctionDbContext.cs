using System;
using AuctionService_controllers.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService_controllers.Data;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Auction> Auctions { get; set; }

}
