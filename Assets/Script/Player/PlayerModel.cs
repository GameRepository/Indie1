using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel :  CharacterModel
{

    SkillTree skills;
    public void ApplyDmg(float dmg)
    {
        if (isInIframe)
            return;
        current_health -= dmg;
        current_health = Mathf.Clamp(current_health, 0, max_health);
    }
    public void ApplyHealth(float health_amount)
    {
        current_health += health_amount;
        current_health = Mathf.Clamp(current_health, 0, max_health);
    }
    
}
