using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI
{
    public sealed class UIExperience : MonoBehaviour, IDisposable
    {
        [Inject] private CharacterExperience _characterExperience;
        [SerializeField] private Button _expUpButton;

        private void Start()
        {
            _expUpButton.onClick.AddListener(Executive);
        }

        private void Executive()
        {
            _characterExperience.AddExperience(10);
        }

        public void Dispose()
        {
            _expUpButton.onClick.RemoveListener(Executive);
        }
    }
}