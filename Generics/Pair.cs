namespace Generics
{
    class Pair : Pair<int>
    {
        public Pair(int first, int second) : base(first, second) { }
    }

    class Pair<T> : Pair<T, T>
    {
        public Pair(T first, T second) : base(first, second) { }
    }

    class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public override string ToString()
        {
            return "[" + First.ToString()
                + ", " + Second.ToString() + "]";
        }
    }
}