using System;
using System.Collections.Generic;

namespace LifeCNC.Models
{
    public partial class SurveyQuestion
    {
        public SurveyQuestion()
        {
            this.SurveyAnswers = new List<SurveyAnswer>();
        }

        public int Id { get; set; }
        public string Question { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; }
    }
}
