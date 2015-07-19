namespace Slight.UrlSharp.Server.Actors
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection;

    using MySql.Data.Entity;

    using Slight.UrlSharp.Server.Models;
    using Slight.UrlSharp.Server.Models.Interfaces;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class SiteContext : DbContext
    {
        public DbSet<Url> Urls { get; set; }

        public override int SaveChanges()
        {
            foreach (var dbType in DbTypes())
            {
                
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        private IEnumerable<Type> DbTypes()
        {
            return GetType().GetProperties(BindingFlags.Public | BindingFlags.GetProperty).Select(x => x.PropertyType).Where(x => typeof(IEntity).IsAssignableFrom(x));
        }
    }
}
