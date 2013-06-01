using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LifeCNC.Models.Mapping;

namespace LifeCNC.Models
{
    public partial class survey_dbContext : DbContext
    {
        static survey_dbContext()
        {
            Database.SetInitializer<survey_dbContext>(null);
        }

        public survey_dbContext()
            : base("Name=survey_dbContext")
        {
        }

        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SurveyAnswerMap());
            modelBuilder.Configurations.Add(new SurveyQuestionMap());
        }
    }
}
