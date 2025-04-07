using System;
using UnityEngine;

namespace UI
{
    public sealed class CharacterParametersStorage
    {
        public string CurrentcyNameCharacter;
        public string CurrentcyCatchPhraseCharacter;
        public Sprite CurrentcyIconCharacter;
        public long CurrentcyLevelCharacter;
        public event Action OnValueChanged; 

        public CharacterParametersStorage(string baseNameCharacter, string baseCatchPhrase, Sprite baseIconCharacter, long baseLevelCharacter)
        {
            CurrentcyNameCharacter = baseNameCharacter;
            CurrentcyCatchPhraseCharacter = baseCatchPhrase;
            CurrentcyIconCharacter = baseIconCharacter;
            CurrentcyLevelCharacter = baseLevelCharacter;
        }

        public void ChangeLevel()
        {
            
        }
    }
}