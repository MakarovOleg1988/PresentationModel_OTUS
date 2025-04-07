using System;

namespace UI
{
    public sealed class PlayerLevel
    {
        public event Action OnLevelUp;
        public event Action<int> OnExperienceChanged;
        public int BaseLevel { get; private set; } = 1;
        public int CurrentLevel { get; private set; }
        public int CurrentExperience { get; private set; }
        public int RequiredExperience
        {
            get { return 100 * (CurrentLevel + 1); }
        }

        public void AddExperience(int range)
        {
            var exp = Math.Min(this.CurrentExperience + range, this.RequiredExperience);

            CurrentExperience = exp;
            OnExperienceChanged?.Invoke(exp);
        }

        public void LevelUp()
        {
            if (CanLevelUp())
            {
                this.CurrentExperience = 0;
                this.CurrentLevel++;
                this.OnLevelUp?.Invoke();
            }
        }

        public bool CanLevelUp()
        {
            return CurrentExperience >= RequiredExperience;
        }
    }
}