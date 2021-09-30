using PairingTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PairingTest.Web.Services
{
    public class QuestinareService : IQuestinareService
    {
        HttpClient _httpClient;
        public QuestinareService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("questinareApi");
        }
        public async Task<QuestionnaireViewModel> GetAllQuestinare()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("/api/questions");
            var questionsAsJson = await httpResponseMessage.Content.ReadAsStringAsync();
            QuestionnaireViewModel questions = Newtonsoft.Json.JsonConvert.DeserializeObject<QuestionnaireViewModel>(questionsAsJson);

            return questions;
        }
    }
}
