using System;
using Zenject;

namespace UI
{
    public sealed class ExperienceObserver : IInitializable, IDisposable
    {
        [Inject] private CharacterExperience _characterExperience;
        private readonly ViewerExperienceInfo _viewerExperienceInfo;

        public ExperienceObserver(ViewerExperienceInfo viewerExperienceInfo)
        {
            _viewerExperienceInfo = viewerExperienceInfo;
        }

        public void Initialize()
        {
            _characterExperience.OnCurrencyExpChanged += CurrencyExpChanged;
            _characterExperience.OnRequiredExpChanged += RequiredExpChanged;
            _characterExperience.OnLevelUp += LevelUp;

            SetBaseData();
        }

        private void SetBaseData()
        {
            _viewerExperienceInfo.UpdateCurrencyExp(_characterExperience.CurrentcyExperience);
            _viewerExperienceInfo.UpdateLevel(_characterExperience.CurrentcyLevelCharacter);
            _viewerExperienceInfo.UpdateRequiredExp(_characterExperience.RequiredExperience);
        }

        private void CurrencyExpChanged(int exp)
        {
            _viewerExperienceInfo.UpdateCurrencyExp(exp);
        }

        private void RequiredExpChanged(int exp)
        {
            _viewerExperienceInfo.UpdateRequiredExp(exp);
        }

        private void LevelUp(int level)
        {
            _viewerExperienceInfo.UpdateLevel(level);
        }      

        public void Dispose()
        {
            _characterExperience.OnCurrencyExpChanged -= CurrencyExpChanged;
            _characterExperience.OnRequiredExpChanged -= RequiredExpChanged;
            _characterExperience.OnLevelUp -= LevelUp;
        }


    }
}