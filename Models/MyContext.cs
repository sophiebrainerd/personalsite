using Microsoft.EntityFrameworkCore;

namespace SB.com.Models
{

    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

    }

}