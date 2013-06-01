using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LifeCNC.Models.Mapping
{
    public class SurveyAnswerMap : EntityTypeConfiguration<SurveyAnswer>
    {
        public SurveyAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Answer)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("SurveyAnswer", "rickjr82");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.QuestionId).HasColumnName("QuestionId");

            // Relationships
            this.HasRequired(t => t.SurveyQuestion)
                .WithMany(t => t.SurveyAnswers)
                .HasForeignKey(d => d.QuestionId);

        }
    }
}
