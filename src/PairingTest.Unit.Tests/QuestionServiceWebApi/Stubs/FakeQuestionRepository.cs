using PairingTest.WebApi;
using PairingTest.WebApi.Interfaces;
using PairingTest.WebApi.Models;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi.Stubs
{
    public class FakeQuestionRepository : IQuestionRepository
    {
        public Questionnaire ExpectedQuestions { get; set; }

        public void AddQuestion(QuestionRequest question)
        {
            throw new System.NotImplementedException();
        }

        public Questionnaire GetQuestionnaire()
        {
            return ExpectedQuestions;

        }
    }
}