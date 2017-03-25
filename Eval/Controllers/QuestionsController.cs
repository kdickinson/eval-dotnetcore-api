using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Eval.Models;
using Eval.Data;
using System.Linq;

namespace Eval.Controllers
{
    [Produces("application/json")]
    [Route("api/Questions")]
    public class QuestionsController : Controller
    {
        // GET: api/Questions
        [HttpGet]
        public IEnumerable<Question> Get()
        {
            return Mock.GetQuestions();
        }

        // GET: api/Questions/5
        [HttpGet("{id}", Name = "Get")]
        public Question Get(int id)
        {
            IEnumerable<Question> questions = Mock.GetQuestions();
            var question = questions.FirstOrDefault(q => q.Ordinal == id);
            return question;     
        }

    }
}
