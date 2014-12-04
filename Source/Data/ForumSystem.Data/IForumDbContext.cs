namespace ForumSystem.Data
{
    using System.Data.Entity;
    using ForumSystem.Data.Models;
    using System.Data.Entity.Infrastructure;
    using System;

    public interface IForumDbContext<TUser, TRole> : IForumDbContext
        where TUser : class
        where TRole : class
    {
        IDbSet<TRole> Roles { get; set; }
        
        IDbSet<TUser> Users { get; set; }
    }

    public interface IForumDbContext : IDisposable
    {
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
