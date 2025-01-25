using System;
using Microsoft.EntityFrameworkCore;
using PizzaFamily.Models;

namespace PizzaFamily.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}

