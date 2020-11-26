using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lab09_Entity_Framework.Models
{
	public class RestaurantContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Food> Foods { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Entity<Food>()
				.HasRequired(x => x.Category)
				.WithMany()
				.HasForeignKey(x => x.FoodCategoryId)
				.WillCascadeOnDelete(true);
		}
	}
}
