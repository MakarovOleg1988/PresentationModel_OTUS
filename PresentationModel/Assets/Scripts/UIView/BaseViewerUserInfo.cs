using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI
{
    public class BaseViewerParamerers : MonoBehaviour
    {
        private CharacterParametersStorage _characterParametersStorage;
        [SerializeField] private TextMeshProUGUI _currentcyNameText;
        [SerializeField] private TextMeshProUGUI _currentcyCatchPhraseText;
        [SerializeField] private Image _currentcyIconImage;
        [SerializeField] private TextMeshProUGUI _currentcyLevelCharacterText;

        [Inject]
        public void Constract(CharacterParametersStorage characterParametersStorage)
        {
            _characterParametersStorage = characterParametersStorage;

        }

        private void LateUpdate()
        {
            Show();
        }

        private void Show()
        {
            _currentcyNameText.text = _characterParametersStorage.CurrentcyNameCharacter;
            _currentcyCatchPhraseText.text = _characterParametersStorage.CurrentcyCatchPhraseCharacter;

            Image icon = _currentcyIconImage.GetComponent<Image>();
            icon.sprite = _characterParametersStorage.CurrentcyIconCharacter;

            string level = _characterParametersStorage.CurrentcyLevelCharacter.ToString();
            _currentcyLevelCharacterText.text = $"Level: {level}";
        }
    }
}