using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    Id = Guid.NewGuid(),
                    Avatar = "avatar.jpg",
                    FullName = "Wissem Hmidi",
                    Profil = "Software Developer in C#"
                }
                );

            modelBuilder.Entity<PortfolioItem>().HasData(
               new PortfolioItem()
               {
                   Id = Guid.NewGuid(),
                   ProjectName = "Project Alpha",
                   Description = "Lorem ipsum odor amet, consectetuer adipiscing elit. " +
                          "Interdum magnis justo primis ligula facilisi non torquent pulvinar. " +
                          "Tellus tortor morbi ullamcorper sagittis proin quam. " +
                          "Parturient Lacinia blandit rutrum; turpis elit taciti " +
                          "dignissim suspendisse. " +
                          "Quis gravida curae, tellus vulputate urna venenatis." +
                          " Nisl viverra curabitur a pretium suscipit.",
                   ImageUrl = "cake.png"
               },
        new PortfolioItem()
        {
            Id = Guid.NewGuid(),
            ProjectName = "Project Beta",
            Description = "Ut enim ad minim veniam, quis nostrud exercitation ullamco " +
            "laboris nisi ut aliquip ex ea commodo consequat. " +
                          "Duis aute irure dolor in reprehenderit in voluptate velit " +
                          "esse cillum dolore eu fugiat nulla pariatur.",
            ImageUrl = "circus.png"
        },
        new PortfolioItem()
        {
            Id = Guid.NewGuid(),
            ProjectName = "Project Gamma",
            Description = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
            " Ut enim ad minim veniam, quis nostrud exercitation.",
            ImageUrl = "safe.png"
        },
        new PortfolioItem()
        {
            Id = Guid.NewGuid(),
            ProjectName = "Project Delta",
            Description = "Curabitur gravida arcu ac tortor dignissim convallis." +
            " Aenean et tortor at risus viverra adipiscing at in tellus.",
            ImageUrl = "submarine.png"
        }
       
               );
        }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }

    }
}
