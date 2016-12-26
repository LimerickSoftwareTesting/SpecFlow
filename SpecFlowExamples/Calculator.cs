using System.Collections.Generic;

namespace SpecFlowExamples
{
    internal class Calculator
    {
        public int Display { get; internal set; }
        private List<int> Values { get; } = new List<int>();

        public Calculator()
        {

        }

        internal void Enter(int number)
        {
            Values.Add(number);
        }

        internal void Add()
        {
            foreach (var value in Values)
            {
                this.Display = this.Display + value;
            }
        }
    }
}