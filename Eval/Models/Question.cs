using System;

namespace Eval.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public int Ordinal { get; set; }
        public string Concept { get; set; }
        public TaxonomyLevel Level { get; set; }
        public QuestionType Type { get; set; }
        public string Text { get; set; }
        public Distractor[] Distractors { get; set; }

        public enum TaxonomyLevel
        {
            Knowledge,
            Comprehension,
            Application,
            Analysis,
            Synthesis,
            Evaluation
        }

        public enum QuestionType
        {
            MultipleChoice,
            TrueFalse,
            MultipleAnswer,
            Matching,
            SingleAnswer,
            ShortAnswer,
            Essay
        }
    }
}
