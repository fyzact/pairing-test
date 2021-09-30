using PairingTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairingTest.Web.Services
{
   public interface IQuestinareService
    {
       Task<QuestionnaireViewModel> GetAllQuestinare();
    }
}
