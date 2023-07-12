using Microsoft.EntityFrameworkCore;

namespace Bulky.MVC.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        
    }
}