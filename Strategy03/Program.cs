using System;
using System.Collections.Generic;

namespace Strategy03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new DefaultSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ReverseSort());
            studentRecords.Sort();
        }
    }

    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    public class DefaultSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("DefaultSort strategy");
        }
    }

    public class ReverseSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Reverse();
            Console.WriteLine("ReverseSort strategy");
        }
    }

    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            sortstrategy.Sort(list);
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
