using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Reflection;
using TestProject.DomainModel.Entities.Identity;

namespace TestProject.Data.DataContext
{
    public class TestProjectContext : IdentityDbContext<ApplicationUser>, IDataContext
    {
        private static int id = 0;

        private int idObj = ++id;

        public TestProjectContext() : base("DefaultConnection", false)
        {
        }

        public bool AutoDetectChangesEnabled
        {
            get { return Configuration.AutoDetectChangesEnabled; }
            set { Configuration.AutoDetectChangesEnabled = value; }
        }

        public void DetectChanges()
        {
            ChangeTracker.DetectChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(TestProjectContext)));
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return ((DbContext) this).Set<TEntity>();
        }
    }
}