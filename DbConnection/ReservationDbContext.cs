using Microsoft.EntityFrameworkCore;
using ReservationEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbConnection
{
    public class ReservationDbContext: DbContext
    {
            public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
            {

            }
            public DbSet<Reservation> Reservations { get; set; }
        }
    }

