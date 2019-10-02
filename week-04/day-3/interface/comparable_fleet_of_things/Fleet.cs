﻿using System;
using System.Collections.Generic;

namespace comparable
{
    public class Fleet
    {
        private List<Thing> things;

        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing, bool completed)
        {
            if (completed)
            {
                thing.Complete();
            }
            things.Add(thing);
        }

        public void Print()
        {
            int i = 0;

            foreach (var thing in things)
            {
                i++;

                Console.Write($"{i}.");

                if (thing.completed)
                {
                    Console.Write($" [x] {thing.name}");
                }
                else
                {
                    Console.Write($" [ ] {thing.name}");
                }
                Console.WriteLine();
            }
        }

        public void Sort()
        {
            things.Sort();
        }

        public void Reverse()
        {
            things.Reverse();
        }

        //    internal void Sort()
        //    {
        //        throw new NotImplementedException();
        //    }
    }
}
