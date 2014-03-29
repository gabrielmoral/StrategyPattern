using StrategyPattern.Behavior;
using StrategyPattern.Domain;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new FileRepository(new CsvBehavior());

            repository.Save();

            repository.ChangeSaveStrategy(new JsonBehavior());

            repository.Save();

            Console.Read();
        }
    }
}
