using TMPro;
using UnityEngine;
using Zenject;

namespace UI
{
    public class ViewerStatsInfo : MonoBehaviour
    {
        private CharacterStatsStorage _characterStatsStorage;
        [SerializeField] private TextMeshProUGUI _currentcyMoveSpeedText;
        [SerializeField] private TextMeshProUGUI _currentcyStaminaText;
        [SerializeField] private TextMeshProUGUI _currentcyDexterityText;
        [SerializeField] private TextMeshProUGUI _currentcyIntelligenceText;
        [SerializeField] private TextMeshProUGUI _currentcyDamageText;
        [SerializeField] private TextMeshProUGUI _currentcyRegenerationText;

        [Inject]
        public void Constract(CharacterStatsStorage characterStatsStorage)
        {
            _characterStatsStorage = characterStatsStorage;
        } 

        private void LateUpdate()
        {
            Show();
        }

        private void Show()
        {
            _currentcyMoveSpeedText.text = _characterStatsStorage.CurrentcyMoveSpeed.ToString();
            _currentcyStaminaText.text = _characterStatsStorage.CurrentcyStamina.ToString();
            _currentcyDexterityText.text = _characterStatsStorage.CurrentcyDexterity.ToString();
            _currentcyIntelligenceText.text = _characterStatsStorage.CurrentcyIntelligence.ToString();
            _currentcyDamageText.text = _characterStatsStorage.CurrentcyDamage.ToString();
            _currentcyRegenerationText.text = _characterStatsStorage.CurrentcyRegeneration.ToString();
        }
    }
}