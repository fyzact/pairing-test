using Microsoft.AspNetCore.Mvc;
using PairingTest.WebApi.Interfaces;
using PairingTest.WebApi.Models;
using System;

namespace PairingTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        // GET api/questions
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_questionRepository.GetQuestionnaire());
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "";
        }

        // POST api/questions
        [HttpPost]
        public IActionResult Post([FromBody] QuestionRequest question)
        {
            _questionRepository.AddQuestion(question);
            return CreatedAtAction("Get", new { id = Guid.NewGuid() }, question);
        }

        // PUT api/questions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/questions/5
        public void Delete(int id)
        {
        }
    }
}
