using Zenject;

namespace UI
{
    public class SceneInstaller : MonoInstaller
    {
        [Inject] private BaseParametersCharacter _baseParam;

        public override void InstallBindings()
        {
            Container.Bind<CharacterParametersStorage>()
            .AsSingle()
            .WithArguments(_baseParam.BaseNameCharacter, _baseParam.BaseCatchPhrase, _baseParam.BaseIconCharacter, _baseParam.BaseLevelCharacter);
            
            Container.Bind<CharacterStat>().AsSingle();
            Container.Bind<PlayerLevel>().AsSingle();
        }
    }
}