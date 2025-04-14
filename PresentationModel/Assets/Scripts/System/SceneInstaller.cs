using Zenject;

namespace UI
{
    public class SceneInstaller : MonoInstaller
    {
        [Inject] private BaseParametersCharacter _baseParam;
        [Inject] private BaseStatsCharacter _baseStats;
        [Inject] private BaseExperienceCharacter _baseExperienceCharacter;

        public override void InstallBindings()
        {
            Container.Bind<CharacterExperience>()
            .AsSingle()
            .WithArguments(_baseExperienceCharacter.BaseExperience, _baseExperienceCharacter.BaseLevel);

            ViewerExperienceInfo view = FindObjectOfType<ViewerExperienceInfo>(); 

            Container.BindInterfacesAndSelfTo<ExperienceObserver>()
            .AsSingle()
            .WithArguments(view);

            Container.Bind<CharacterParametersStorage>()
            .AsSingle()
            .WithArguments(_baseParam.BaseNameCharacter, _baseParam.BaseCatchPhrase, _baseParam.BaseIconCharacter);
            
            Container.BindInterfacesAndSelfTo<CharacterStatsStorage>()
            .AsSingle()
            .WithArguments(_baseStats.BaseMoveSpeed, _baseStats.BaseStamina, _baseStats.BaseDexterity, _baseStats.BaseIntelligence, _baseStats.BaseDamage, _baseStats.BaseRegeneration); 
        }
    }
}