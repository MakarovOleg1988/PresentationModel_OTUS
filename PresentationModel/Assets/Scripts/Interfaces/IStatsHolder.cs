using UnityEngine;

namespace UI
{
    public interface IBaseParameters
    {
        public string BaseNameCharacter { get; }
        public string BaseCatchPhrase { get; }
        public Sprite BaseIconCharacter { get; }
        public long BaseLevelCharacter { get; }
    }

        public interface IBaseStats
    {
        public long MoveSpeed { get; }
        public long Stamina { get; }
        public long Dexterity { get; }
        public long Intelligence { get; }
        public long Damage { get; }
        public long Regeneration { get; }
    }
}