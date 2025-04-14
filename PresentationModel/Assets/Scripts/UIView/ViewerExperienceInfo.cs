using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ViewerExperienceInfo : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _currentcyExperienceText;
        [SerializeField] private TextMeshProUGUI _requiredExperienceText;
        [SerializeField] private TextMeshProUGUI _currentcyLevelCharacterText;
        [SerializeField] private Slider _expSlider;

        public void UpdateCurrencyExp(int expValue)
        {
            _currentcyExperienceText.text = expValue.ToString();
        }

        public void UpdateRequiredExp(int expValue)
        {
            _requiredExperienceText.text = expValue.ToString();
        }

        public void UpdateLevel(int levelValue)
        {
            string level = levelValue.ToString();
            _currentcyLevelCharacterText.text = $"Level: {level}";
        }
    }
}