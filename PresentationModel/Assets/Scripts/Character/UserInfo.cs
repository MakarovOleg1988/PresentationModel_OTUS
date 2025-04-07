using System;
using UnityEngine;

namespace UI
{
    public sealed class UserInfo
    {
        public event Action<string> OnNameChanged;
        public event Action<string> OnCatchPhraseChanged;
        public event Action<Sprite> OnIconChanged; 

        public string Name { get; private set; }
        public string CatchPhrase { get; private set; }
        public Sprite Icon { get; private set; }

        public void ChangeName(string name)
        {
            this.Name = name;
            this.OnNameChanged?.Invoke(name);
        }

        public void ChangeCatchPhrase(string catchPhrase)
        {
            this.CatchPhrase = catchPhrase;
            this.OnCatchPhraseChanged?.Invoke(catchPhrase);
        }

        public void ChangeIcon(Sprite icon)
        {
            this.Icon = icon;
            this.OnIconChanged?.Invoke(icon);
        }
    }
}