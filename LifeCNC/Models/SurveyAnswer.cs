using System;
using System.Collections.Generic;

namespace LifeCNC.Models
{
    public partial class SurveyAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public int QuestionId { get; set; }
        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
