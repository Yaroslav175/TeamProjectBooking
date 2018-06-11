using System.Data.Entity;

namespace ClassLibrary
{
    class Context : DbContext
    {
        public DbSet<HSEBuilding> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }

        public Context() : base("localsql")
        {
        }
    }
}
