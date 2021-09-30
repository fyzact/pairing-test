using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PairingTest.Web.Models;
using PairingTest.Web.Services;
using System.Threading.Tasks;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IConfiguration _config;

        readonly IQuestinareService _questinareService;

        public QuestionnaireController(IConfiguration config, IQuestinareService questinareService)
        {
            _config = config;
            _questinareService = questinareService;
        }

        public async Task<ViewResult> Index()
        {
            QuestionnaireViewModel questinareViewModel=await _questinareService.GetAllQuestinare();
            return View(questinareViewModel);
        }

        /* ASYNC ACTION METHOD... IF REQUIRED... */
        //public async Task<ViewResult> Index()
        //{
        //}
    }
}
