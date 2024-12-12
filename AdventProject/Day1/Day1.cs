using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventProject
{
    public class Day1
    {
        public void Solve()
        {
            var strings = File.ReadAllLines("Day1\\Input.txt");
            var leftList = new List<int>();
            var rightList = new List<int>();
            foreach (var str in strings)
            {
                var result = str.Split("   ");
                var left = Convert.ToInt32(result[0]);
                var right = Convert.ToInt32(result[1]);
                leftList.Add(left);
                rightList.Add(right);
            }
            var orderedLeftlist = leftList.Order().ToList();
            var orderedRightlist = rightList.Order().ToList();

            var Answer = 0;

            for(int i = 0; i < orderedLeftlist.Count; i++)
            {
                int difference = Math.Abs(orderedLeftlist[i] - orderedRightlist[i]);
                Answer += difference; 
            }


            Console.WriteLine($"Day 1 Problem 1: {Answer}");

            

        }

        public void SolveTwo()
        {
            var strings = File.ReadAllLines("Day1\\Input.txt");
            var leftList = new List<int>();
            var rightList = new List<int>();
            foreach (var str in strings)
            {
                var result = str.Split("   ");
                var left = Convert.ToInt32(result[0]);
                var right = Convert.ToInt32(result[1]);
                leftList.Add(left);
                rightList.Add(right);
            }
            var SimilarityScore = 0;

            foreach(var leftListItem in leftList)
            {
                foreach (var rightListItem in rightList)
                {
                    if (leftListItem == rightListItem)
                    {
                        SimilarityScore += leftListItem;
                    }
                }
            }

            Console.WriteLine($"Day 1 Problem 2: {SimilarityScore}");           
        }
    }
}
