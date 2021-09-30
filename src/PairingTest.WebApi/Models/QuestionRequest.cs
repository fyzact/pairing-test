using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairingTest.WebApi.Models
{
    public class QuestionRequest
    {
        public string QuestionnaireTitle { get; set; }
        public IList<string> QuestionsText { get; set; }
    }
}
