using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ThePalaceMuseumWeb.EF.Model
{
    public partial class MuseumContext : DbContext
    {
        public MuseumContext()
            : base("name=MuseumContext")
        {
        }

        public virtual DbSet<CollectCategory> CollectCategory { get; set; }
        public virtual DbSet<Cultural> Cultural { get; set; }
        public virtual DbSet<Notice> Notice { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Voice> Voice { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
