using System;
using Zenject;

namespace UI
{
    public sealed class CharacterStatsStorage : IInitializable, IDisposable
    {
        [Inject] private CharacterExperience _characterExperience;
        public long CurrentcyMoveSpeed { get; private set; }
        public long CurrentcyStamina { get; private set; }
        public long CurrentcyDexterity { get; private set; }
        public long CurrentcyIntelligence { get; private set; }
        public long CurrentcyDamage { get; private set; }
        public long CurrentcyRegeneration { get; private set; }

        public CharacterStatsStorage(long baseMoveSpeed, long baseStamina, long baseDexterity,
        long baseIntelligence, long baseDamage, long baseRegeneration)
        {
            CurrentcyMoveSpeed = baseMoveSpeed;
            CurrentcyStamina = baseStamina;
            CurrentcyDexterity = baseDexterity;
            CurrentcyIntelligence = baseIntelligence;
            CurrentcyDamage = baseDamage;
            CurrentcyRegeneration = baseRegeneration;
        }

        public void Initialize()
        {
            _characterExperience.OnMoveSpeedChanged += ChangeMoveSpeed;
            _characterExperience.OnStaminaChanged += ChangeStamina;
            _characterExperience.OnDexterityChanged += ChangeDexterity;
            _characterExperience.OnIntelligenceChanged += ChangeIntelligence;
            _characterExperience.OnDamageChanged += ChangeDamage;
            _characterExperience.OnRegenerationChanged += ChangeRegeneration;
        }

        public void ChangeMoveSpeed(long value)
        {
            CurrentcyMoveSpeed += value;
        }

        public void ChangeStamina(long value)
        {
            CurrentcyStamina += value;
        }

        public void ChangeDexterity(long value)
        {
            CurrentcyDexterity += value;
        }

        public void ChangeIntelligence(long value)
        {
            CurrentcyIntelligence += value;
        }

        public void ChangeDamage(long value)
        {
            CurrentcyDamage += value;
        }

        public void ChangeRegeneration(long value)
        {
            CurrentcyRegeneration += value;
        }

        public void Dispose()
        {
            _characterExperience.OnMoveSpeedChanged -= ChangeMoveSpeed;
            _characterExperience.OnStaminaChanged -= ChangeStamina;
            _characterExperience.OnDexterityChanged -= ChangeDexterity;
            _characterExperience.OnIntelligenceChanged -= ChangeIntelligence;
            _characterExperience.OnDamageChanged -= ChangeDamage;
            _characterExperience.OnRegenerationChanged -= ChangeRegeneration;
        }
    }
}