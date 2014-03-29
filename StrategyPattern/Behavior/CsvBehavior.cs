using System;

namespace StrategyPattern.Behavior
{
    public class CsvBehavior : SaveBehavior
    {
        public void Save()
        {
            Console.WriteLine("Save csv file...");
        }
    }
}
