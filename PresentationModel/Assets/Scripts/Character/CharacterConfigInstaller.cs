using System;
using UnityEngine;
using Zenject;

namespace UI
{
    [CreateAssetMenu(fileName = "CharacterStats", menuName = "Data/CharacterStats")]
    public class CharacterConfigInstaller : ScriptableObjectInstaller<CharacterConfigInstaller>
    {
        [SerializeField] public BaseStatsCharacter BaseStatsCharacter;
        [SerializeField] public BaseParametersCharacter BaseParametersCharacter;

        public override void InstallBindings()
        {
            Container.Bind<BaseStatsCharacter>().FromInstance(BaseStatsCharacter).AsSingle();
            Container.Bind<BaseParametersCharacter>().FromInstance(BaseParametersCharacter).AsSingle();
        }
    }

    [Serializable]
    public class BaseStatsCharacter: IBaseStats
    {
        [SerializeField] private long _moveSpeed;
        [SerializeField] private long _stamina;
        [SerializeField] private long _dexterity;
        [SerializeField] private long _intelligence;
        [SerializeField] private long _damage;
        [SerializeField] private long _regeneration;

        public long MoveSpeed => _moveSpeed;
        public long Stamina => _stamina;
        public long Dexterity => _dexterity;
        public long Intelligence => _intelligence;
        public long Damage => _damage;
        public long Regeneration => _regeneration;
    }

    [Serializable]
    public class BaseParametersCharacter: IBaseParameters
    {
        [SerializeField] private string _baseNameCharacter;
        [SerializeField] private string _baseCatchPhrase;
        [SerializeField] private Sprite _baseIconCharacter;
        [SerializeField] private long _baseLevelCharacter;

        public string BaseNameCharacter => _baseNameCharacter;
        public string BaseCatchPhrase => _baseCatchPhrase;
        public Sprite BaseIconCharacter => _baseIconCharacter;
        public long BaseLevelCharacter => _baseLevelCharacter;
    }
}
