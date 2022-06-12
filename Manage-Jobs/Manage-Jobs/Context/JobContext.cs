using Manage_Jobs.Model;
using Microsoft.EntityFrameworkCore;

namespace Manage_Jobs.Context {
    internal class JobContext : DbContext {
        public DbSet<Job> Job { get; set; }

        public string DbPath { get; }

        public JobContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "MangeJob.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
