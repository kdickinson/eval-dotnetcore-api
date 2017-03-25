using System;
using Eval.Models;

namespace Eval.Data
{
    public class Mock
    {
        public static Question[] GetQuestions()
        {
            Question[] Questions = new Question[] {
                new Question
                {
                    Id = Guid.NewGuid(),
                    Ordinal = 0,
                    Concept = "cutlery",
                    Level = Question.TaxonomyLevel.Knowledge,
                    Type = Question.QuestionType.MultipleChoice,
                    Text = "Which of the following is a picture of a spoon?",
                    Distractors = new Distractor[]
                    {
                        new Distractor("picture of spoon", true),
                        new Distractor("picture of knife"),
                        new Distractor("picture of fork"),
                        new Distractor("picture of car")
                    }
                },
               new Question
                {
                    Id = Guid.NewGuid(),
                    Ordinal = 1,
                    Concept = "cutlery",
                    Level = Question.TaxonomyLevel.Knowledge,
                    Type = Question.QuestionType.MultipleChoice,
                    Text = "Which of the following is typically eaten without cutlery?",
                    Distractors = new Distractor[]
                    {
                        new Distractor("Fried Chicken", true),
                        new Distractor("Steak"),
                        new Distractor("Casserole"),
                        new Distractor("Scrambled Eggs")
                    }
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Ordinal = 2,
                    Concept = "cutlery",
                    Level = Question.TaxonomyLevel.Knowledge,
                    Type = Question.QuestionType.MultipleChoice,
                    Text = "Which of the following is typically used to spread butter on bread?",
                    Distractors = new Distractor[]
                    {
                        new Distractor("Knive", true),
                        new Distractor("Fork"),
                        new Distractor("Spoon"),
                        new Distractor("Chopsticks")
                    }
                },
                new Question
                {
                    Id = Guid.NewGuid(),
                    Ordinal = 3,
                    Concept = "cutlery",
                    Level = Question.TaxonomyLevel.Knowledge,
                    Type = Question.QuestionType.MultipleChoice,
                    Text = "Which of the following would usually require a knife to aid in eating?",
                    Distractors = new Distractor[]
                    {
                        new Distractor("Steak", true),
                        new Distractor("Soup"),
                        new Distractor("Eggs"),
                        new Distractor("Cereal")
                    }
                },               new Question
                {
                    Id = Guid.NewGuid(),
                    Ordinal = 4,
                    Concept = "cutlery",
                    Level = Question.TaxonomyLevel.Knowledge,
                    Type = Question.QuestionType.MultipleChoice,
                    Text = "Which of the following is best eaten with a spoon?",
                    Distractors = new Distractor[]
                    {
                        new Distractor("Soup", true),
                        new Distractor("Steak"),
                        new Distractor("Apple"),
                        new Distractor("Car")
                    }
                },               new Question
                {
                    Id = Guid.NewGuid(),
                    Ordinal = 5,
                    Concept = "cutlery",
                    Level = Question.TaxonomyLevel.Knowledge,
                    Type = Question.QuestionType.MultipleChoice,
                    Text = "Which of the following is a picture of a spoon?",
                    Distractors = new Distractor[]
                    {
                        new Distractor("picture of spoon", true),
                        new Distractor("picture of knife"),
                        new Distractor("picture of fork"),
                        new Distractor("picture of car")
                    }
                },               new Question
                {
                    Id = Guid.NewGuid(),
                    Ordinal = 6,
                    Concept = "cutlery",
                    Level = Question.TaxonomyLevel.Knowledge,
                    Type = Question.QuestionType.MultipleChoice,
                    Text = "Which of the following is not a picture of cutlery?",
                    Distractors = new Distractor[]
                    {
                        new Distractor("picture of car", true),
                        new Distractor("picture of knife"),
                        new Distractor("picture of fork"),
                        new Distractor("picture of spoon")
                    }
                },            };
            return Questions;
        }
    }
}
