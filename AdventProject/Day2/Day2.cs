using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventProject
{
    public class Day2
    {
        public void Solve()
        {
            var strings = File.ReadAllLines("Day2\\Input2.txt");

            var listOfReports = new List<List<int>>();

            foreach (var str in strings)
            {
                var result = str.Split(" ");
                var intList = new List<int>();

                foreach (var item in result)
                {
                    intList.Add(int.Parse(item));
                }
                listOfReports.Add(intList);
            }
            int SafeReports = 0;
            foreach (var report in listOfReports)
            {
                if (IsProperAscending(report) || IsProperDescending(report))
                {
                    SafeReports += 1;
                }
                else if (Dampener(report))
                {
                    SafeReports += 1;
                }
            }
            

            Console.WriteLine($"Day 2 Problem 2: {SafeReports}");
        }

        public bool IsProperAscending(List<int> report)
        {
            for (int i = 0; i < report.Count-1; i++)
            {
                if (report[i] >= report[i + 1])
                {
                    return false;
                }
                else if (report[i + 1] - report[i] > 3)
                {
                    return false;
                }

            }
          
            return true;
        }

        public bool IsProperDescending(List<int> report)
        {
            for (int i = 0; i < report.Count - 1; i++)
            {
                if (report[i] <= report[i + 1])
                {
                    return false;
                }
                if (report[i] - report[i + 1] > 3)
                {
                    return false;
                }
            }

            return true;
        }
        public bool Dampener (List<int> report)
        {
            for (int i = 0; i < report.Count; i++)
            {
                var tempList = new List<int>(report);

                tempList.RemoveAt(i);
                
                if (IsProperAscending (tempList) || IsProperDescending(tempList))
                {
                    return true;
                }
            }

            return false;
        }

    }
}