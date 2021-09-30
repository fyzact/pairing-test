using System.Collections.Generic;
using PairingTest.WebApi.Interfaces;
using PairingTest.WebApi.Models;

namespace PairingTest.WebApi
{
    public class QuestionRepository : IQuestionRepository
    {
        public List<Questionnaire> questionsStore;
        public QuestionRepository()
        {
            questionsStore = new List<Questionnaire>();
            questionsStore.Add(new Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?"
                }
            });
        }
        public void AddQuestion(QuestionRequest question)
        {
            questionsStore.Add(new Questionnaire
            {
                QuestionnaireTitle = question.QuestionnaireTitle,
                QuestionsText = question.QuestionsText
            });

        }

        public Questionnaire GetQuestionnaire()
        {
            return new Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?"
                }
            };
        }
    }
}