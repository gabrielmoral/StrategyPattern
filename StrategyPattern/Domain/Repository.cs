using StrategyPattern.Behavior;

namespace StrategyPattern.Domain
{
    public abstract class Repository
    {
        protected SaveBehavior saveBehavior;

        public void Save()
        {
            saveBehavior.Save();
        }

        public void ChangeSaveStrategy(SaveBehavior saveBehavior)
        {
            this.saveBehavior = saveBehavior;
        }
    }
}
