namespace eShop.EntityFramework.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using eShop.Core.Domain.Users;

    public partial class eShopDbContext : DbContext
    {
        public eShopDbContext()
            : base("name=eShopDbContext")
        {
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
