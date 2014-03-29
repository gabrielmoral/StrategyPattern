using StrategyPattern.Behavior;

namespace StrategyPattern.Domain
{
    public class FileRepository : Repository
    {
        public FileRepository(SaveBehavior saveBehavior)
        {
            base.saveBehavior = saveBehavior;
        }
    }
}
