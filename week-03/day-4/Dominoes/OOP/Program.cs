using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            SortDominoes(dominoes);
        }

        public static void SortDominoes(List<Domino> originalSet)
        {
            List<Domino> newSet = new List<Domino>();
            newSet.Add(originalSet[0]);

            for (int i = 0; i < originalSet.Count-1; i++)
            {
                int compareSecondValue = newSet[i].GetValues()[1];
                foreach (var domino in originalSet)
                {
                    if (compareSecondValue == domino.GetValues()[0])
                    {
                        int dominoNumLeft = domino.GetValues()[0];
                        int dominoNumRight = domino.GetValues()[1];
                        newSet.Add(new Domino(dominoNumLeft, dominoNumRight));
                    }
                }
            }
            foreach (var domino in newSet)
            {
                Console.Write($"[{domino.GetValues()[0]}, {domino.GetValues()[1]}] ");
            }
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}
