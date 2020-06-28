using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CommandAPI.Models;

namespace CommandAPI.Context
{
    public class ApplicationDBContext : DbContext
    {
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
    :base(options)
    {

    }
    public DbSet<Command> Commands { get; set; }

    }
}