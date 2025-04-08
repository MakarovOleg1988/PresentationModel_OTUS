using System;
using UnityEngine;

namespace UI
{
    public sealed class CharacterParametersStorage
    {
        public string CurrentcyNameCharacter;
        public string CurrentcyCatchPhraseCharacter;
        public Sprite CurrentcyIconCharacter;
        public event Action<string> OnNameChanged;
        public event Action<string> OnCatchPhraseChanged;
        public event Action<Sprite> OnIconChanged; 

        public CharacterParametersStorage(string baseNameCharacter, string baseCatchPhrase, Sprite baseIconCharacter)
        {
            CurrentcyNameCharacter = baseNameCharacter;
            CurrentcyCatchPhraseCharacter = baseCatchPhrase;
            CurrentcyIconCharacter = baseIconCharacter;
        }

        public void ChangeName(string name)
        {
            CurrentcyNameCharacter = name;
            OnNameChanged?.Invoke(name);
        }

        public void ChangeCatchPhrase(string catchPhrase)
        {
            CurrentcyCatchPhraseCharacter = catchPhrase;
            OnCatchPhraseChanged?.Invoke(catchPhrase);
        }

        public void ChangeIcon(Sprite icon)
        {
            CurrentcyIconCharacter = icon;
            OnIconChanged?.Invoke(icon);
        }
    }
}