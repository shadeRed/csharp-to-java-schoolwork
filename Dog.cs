﻿namespace Java_to_CSharp_Exercise
{
    class Dog : Pet, ITalkable
    {
        private bool friendly;
        public Dog(bool friendly, string name) : base(name) {
            this.friendly = friendly;
        }

        public bool IsFriendly() { return friendly; }

        public string Talk() { return "Bark"; }
        public override string ToString()
        {
            return $"Dog: name={name} friendly={friendly}";
        }
    }
}
