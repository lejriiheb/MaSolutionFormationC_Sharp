namespace Banking.BackOffice.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBanque : DbContext
    {
        public ModelBanque()
            : base("name=ModelBanque")
        {
        }

        public virtual DbSet<Comptes> Comptes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
