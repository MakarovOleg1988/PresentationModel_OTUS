using UnityEngine;

namespace UI
{
    public interface IBaseParameters
    {
        public string BaseNameCharacter { get; }
        public string BaseCatchPhrase { get; }
        public Sprite BaseIconCharacter { get; }
    }

    public interface IBaseStats
    {
        public long BaseMoveSpeed { get; }
        public long BaseStamina { get; }
        public long BaseDexterity { get; }
        public long BaseIntelligence { get; }
        public long BaseDamage { get; }
        public long BaseRegeneration { get; }
    }

    public interface IBaseExp
    {
        public int BaseExperience { get; }
        public int BaseLevel { get; }

    }
}