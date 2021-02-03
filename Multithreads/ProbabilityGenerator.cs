using System;

namespace Multithreads
{
    class ProbabilityGenerator
    {
        private int rand_coef = 50;
        public int Rand_coef
        {
            get => rand_coef;
            private set
            {
                if (value >= 0 && value <= 100)
                    rand_coef = value;
            }
        }

        public ProbabilityGenerator(int _rand_coef) {
            Rand_coef = _rand_coef;
        }

        public bool Generate() {
            return new Random().Next(0, 100) < rand_coef;
        }
    }
}
