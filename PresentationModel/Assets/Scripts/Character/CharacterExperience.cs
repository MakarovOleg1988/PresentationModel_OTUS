using System;
using Zenject;

namespace UI
{
    public sealed class CharacterExperience
    {
        public int CurrentcyExperience { get; private set; }
        public int CurrentcyLevelCharacter;
        public int RequiredExperience
        {
            get { return 100 * (CurrentcyLevelCharacter + 1); }
        }

        private long _boostValue = 1;

        public event Action<int> OnCurrencyExpChanged;
        public event Action<int> OnRequiredExpChanged;
        public event Action<int> OnLevelUp;

        public event Action<long> OnMoveSpeedChanged;
        public event Action<long> OnStaminaChanged;
        public event Action<long> OnDexterityChanged;
        public event Action<long> OnIntelligenceChanged;
        public event Action<long> OnDamageChanged;
        public event Action<long> OnRegenerationChanged;

        public CharacterExperience(int baseExp, int baseLevel)
        {
            CurrentcyExperience = baseExp;
            CurrentcyLevelCharacter = baseLevel;
        }

        public void AddExperience(int range)
        {
            var exp = Math.Min(CurrentcyExperience + range, RequiredExperience);

            CurrentcyExperience = exp;
            OnCurrencyExpChanged?.Invoke(CurrentcyExperience);
            OnRequiredExpChanged?.Invoke(RequiredExperience);

            LevelUp();
        }
        public void LevelUp()
        {
            if (CanLevelUp())
            {
                CurrentcyLevelCharacter++;

                OnLevelUp?.Invoke(CurrentcyLevelCharacter);

                OnMoveSpeedChanged?.Invoke(_boostValue);
                OnStaminaChanged?.Invoke(_boostValue);
                OnDexterityChanged?.Invoke(_boostValue);
                OnIntelligenceChanged?.Invoke(_boostValue);
                OnDamageChanged?.Invoke(_boostValue);
                OnRegenerationChanged?.Invoke(_boostValue);
            }
        }

        public bool CanLevelUp()
        {
            return CurrentcyExperience == RequiredExperience;
        }
    }
}