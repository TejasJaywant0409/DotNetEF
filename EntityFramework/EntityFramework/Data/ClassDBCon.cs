using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class ClassDBCon : DbContext
    {
        public ClassDBCon(DbContextOptions options) : base(options) { }
        
    }
}
