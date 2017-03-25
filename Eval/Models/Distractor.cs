using System;

namespace Eval.Models
{
    public class Distractor
    {
        public string Text { get; set; }
        public bool Correct { get; set; }
        public Guid Id { get; set; }

        public Distractor()
        {
        }
        public Distractor(string text)
        {
            InitializeDestractor();
            Text = text;
        }
        public Distractor(string text, bool correct)
        {
            Text = text;
            Correct = correct;
        }

        private void InitializeDestractor()
        {
            Text = String.Empty;
            Correct = false;
            Id = Guid.NewGuid();
        }
    }
}
