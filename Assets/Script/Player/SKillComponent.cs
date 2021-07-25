using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkillComponent:MonoBehaviour
{
    public SkillComponent parents;
    public bool isActive = false;
    public event Action onSkillUnlocked;
    public void UnlockThisSKill()
    {
        onSkillUnlocked?.Invoke();
    }
}
