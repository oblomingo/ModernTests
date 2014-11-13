using System.Data.Entity;
using ModernTests.Models;

namespace ModernTests.Repository
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("DefaultConnection")
        { }

        public DbSet<Document> FormattedDocuments { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        //public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Create many-to-many type table TestsQuestions
            modelBuilder.Entity<Test>()
                .HasMany<Question>(q => q.Questions)
                .WithMany(t => t.Tests)
                .Map(m =>
                {
                    m.MapLeftKey("TestId");
                    m.MapRightKey("QuestionId");
                    m.ToTable("TestsQuestions");
                });
        }
    }
}
