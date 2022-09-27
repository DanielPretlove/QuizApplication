using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public string QuizType { get; set; }
        public int QuestionId { get; set; }
        public int Response { get; set; }
        public Question Questions { get; set; }         
        public bool Answer { get; set; }
        public int TotalScore { get; set; }
    }
}