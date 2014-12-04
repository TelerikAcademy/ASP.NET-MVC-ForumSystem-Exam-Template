namespace ForumSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using ForumSystem.Data.Common.Models;
    using ForumSystem.Data.Migrations;
    using ForumSystem.Data.Models;

    using Microsoft.AspNet.Identity.EntityFramework;

    public class ForumDbContext : IdentityDbContext<ForumUser>, IForumDbContext<ForumUser, IdentityRole>
    {
        public ForumDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }

        public IDbSet<Tag> Tags { get; set; }

        public IDbSet<Post> Posts { get; set; }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public static ForumDbContext Create()
        {
            return new ForumDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    if (!entity.PreserveCreatedOn)
                    {
                        entity.CreatedOn = DateTime.Now;
                    }
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
