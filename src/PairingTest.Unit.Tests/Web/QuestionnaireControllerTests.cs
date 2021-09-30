using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;
using PairingTest.Web.Services;
using System.Threading.Tasks;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        private Mock<IConfiguration> _config;
        private QuestionnaireController _questionnaireController;
        private Mock<IQuestinareService> _questionService;

        [SetUp]
        public void SetUp()
        {
            _config = new Mock<IConfiguration>();
            _questionService = new Mock<IQuestinareService>();
            _questionnaireController = new QuestionnaireController(_config.Object,_questionService.Object);
        }

        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected quesitons";

            //Act
            var result = (QuestionnaireViewModel)_questionnaireController.Index().Result.Model;

            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}