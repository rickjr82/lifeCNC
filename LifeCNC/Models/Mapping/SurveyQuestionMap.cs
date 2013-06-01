using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LifeCNC.Models.Mapping
{
    public class SurveyQuestionMap : EntityTypeConfiguration<SurveyQuestion>
    {
        public SurveyQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SurveyQuestion", "rickjr82");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Question).HasColumnName("Question");
        }
    }
}
