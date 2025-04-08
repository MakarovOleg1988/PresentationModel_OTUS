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
        [SerializeField] private long _baseMoveSpeed;
        [SerializeField] private long _baseStamina;
        [SerializeField] private long _baseDexterity;
        [SerializeField] private long _baseIntelligence;
        [SerializeField] private long _baseDamage;
        [SerializeField] private long _baseRegeneration;

        public long BaseMoveSpeed => _baseMoveSpeed;
        public long BaseStamina => _baseStamina;
        public long BaseDexterity => _baseDexterity;
        public long BaseIntelligence => _baseIntelligence;
        public long BaseDamage => _baseDamage;
        public long BaseRegeneration => _baseRegeneration;
    }

    [Serializable]
    public class BaseParametersCharacter: IBaseParameters
    {
        [SerializeField] private string _baseNameCharacter;
        [SerializeField] private string _baseCatchPhrase;
        [SerializeField] private Sprite _baseIconCharacter;

        public string BaseNameCharacter => _baseNameCharacter;
        public string BaseCatchPhrase => _baseCatchPhrase;
        public Sprite BaseIconCharacter => _baseIconCharacter;
    }
}
