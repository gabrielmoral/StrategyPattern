using System;

namespace StrategyPattern.Behavior
{
    public class JsonBehavior : SaveBehavior
    {
        public void Save()
        {
            Console.WriteLine("Save json file...");
        }
    }
}
