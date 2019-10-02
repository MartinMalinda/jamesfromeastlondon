using System;

namespace comparable
{
    public class Thing : IComparable<Thing>
    {
        public string name;
        public bool completed;

        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete()
        {
            completed = true;
        }

        public virtual int CompareTo(Thing other)
        {
            return completed.CompareTo(other.completed);
        }
    }
}
