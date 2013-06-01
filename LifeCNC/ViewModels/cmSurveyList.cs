using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LifeCNC.Models;
namespace LifeCNC.ViewModels
{
    public class cmSurveyList
    {
        public cmSurveyList(IEnumerable<SurveyQuestion> surveyQuestions)
        {
            SurveyQuestions = surveyQuestions.Select(x => new vmSurveyQuestion(x));
        }
        public IEnumerable<vmSurveyQuestion> SurveyQuestions;
    }
    public class vmSurveyQuestion
    {
        public IEnumerable<vmSurveyAnswer> SurveyAnswers;
        public string Question;
        public int Id;
       
        public vmSurveyQuestion(SurveyQuestion surveyQuestion)
        {
            Question = surveyQuestion.Question;
            Id = surveyQuestion.Id;
            SurveyAnswers = surveyQuestion.SurveyAnswers.Select(x => new vmSurveyAnswer(x));
        }

    }
    public class vmSurveyAnswer
    {
        public string Answer;
        public int Id;
        public int QuestionId;
      
        public vmSurveyAnswer(SurveyAnswer surveyAnswer)
        {
            Answer = surveyAnswer.Answer;
            Id = surveyAnswer.Id;
            QuestionId = surveyAnswer.QuestionId;
        }
    }
}