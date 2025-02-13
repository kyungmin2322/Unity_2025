using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class SoundManager : ScriptableObject
{
    public event Action<string> OnPlay;

    public void Play(string name)
    {
        if(OnPlay != null)
            OnPlay.Invoke(name);
        // Invoke�� �̺�Ʈ ����� �Լ��̴�.
    }
}
