using Moq;
using Moq.Protected;
using NUnit.Framework;
using PairingTest.Web.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PairingTest.Unit.Tests.Services
{

    [TestFixture]
    public class QuestionServiceTest
    {
       IHttpClientFactory  _mocHttpFactory;

        [SetUp]
        public void SetUp()
        {
            _mocHttpFactory = CreateIHttpMock();
        } 

        [Test]
        public async Task QuestionGet_ShouldReturValue_WhenGetAll()
        {
            IQuestinareService questinareService = new QuestinareService(_mocHttpFactory);
            var result = await questinareService.GetAllQuestinare();

            Assert.IsTrue(result.QuestionsText.Count > 0);
        }


        private IHttpClientFactory CreateIHttpMock()
        {
          Mock< IHttpClientFactory>  mockFactory = new Mock<IHttpClientFactory>();
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{\"questionnaireTitle\":\"Geography Questions2\",\"questionsText\":[\"What is the capital of Cuba ? \",\"What is the capital of France ? \",\"What is the capital of Poland ? \",\"What is the capital of Germany ? \"]}"),
                });

            var client = new HttpClient(mockHttpMessageHandler.Object)
            {
                BaseAddress = new Uri("http://localhost")//To prevent An invalid request URI was provided. The request URI must either be an absolute URI or BaseAddress must be set.
            };
            mockFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(client);
            return mockFactory.Object;

        }




    }



}
