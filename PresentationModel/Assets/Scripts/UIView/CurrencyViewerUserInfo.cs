using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class CurrencyViewerUserInfo : MonoBehaviour
    {
        [SerializeField] private Button _AddExperienceButton;

        private void Start()
        {
            _AddExperienceButton.onClick.AddListener(AddExperience);
        }

        private void AddExperience()
        {
            
        }

        private void OnDestroy()
        {
            _AddExperienceButton.onClick.RemoveListener(AddExperience);
        }
    }
}