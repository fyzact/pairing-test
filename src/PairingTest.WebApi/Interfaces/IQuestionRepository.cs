using PairingTest.WebApi.Models;

namespace PairingTest.WebApi.Interfaces
{
    public interface IQuestionRepository
    {
        Questionnaire GetQuestionnaire();
        void AddQuestion(QuestionRequest question);
    }
}
