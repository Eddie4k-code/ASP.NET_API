using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_api.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }

        public DbSet<Character> Characters {get; set;}



        
    }
}