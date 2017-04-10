using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTestMVC.Models
{
    public class QaQuizViewModel
    {
        public string Question { get; set; }
        public IEnumerable<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; } // Zero based
    }
}