using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eval.Data;
using Eval.Models;
using System.Collections.Generic;
using System.Linq;

namespace Eval.Test
{
    [TestClass]
    public class QuestionsControllerTest
    {
        [TestMethod]
        public void GetAllMocksTest()
        {
            var questions = (IEnumerable<Question>)Mock.GetQuestions();
            Assert.IsNull(questions.FirstOrDefault(q => q.Ordinal == 10));
            Assert.IsNotNull(questions.FirstOrDefault(q => q.Ordinal == 2));
            Assert.IsFalse(questions.FirstOrDefault(q => q.Ordinal == 0).Text == "Which of the following is a picture of an elephant?");
            Assert.IsTrue(questions.FirstOrDefault(q => q.Ordinal == 0).Text == "Which of the following is a picture of a spoon?");
            Assert.IsTrue(questions.FirstOrDefault(q => q.Ordinal == 3).Distractors.Length > 0);
        }
    }
}
