using Microsoft.EntityFrameworkCore;
using project_tracker.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace project_tracker.Data {
    public class ApplicationDBContext : DbContext {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {

        }
        public DbSet<Issue> Issues { get; set; }
    }
}
