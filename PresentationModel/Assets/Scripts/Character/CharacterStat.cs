using System;

namespace UI
{
    public sealed class CharacterStat
    {
        public event Action<int> OnValueChanged; 
        public int Value { get; private set; }

        public void ChangeValue(int value)
        {
            Value = value;
            OnValueChanged?.Invoke(value);
        }
    }
}