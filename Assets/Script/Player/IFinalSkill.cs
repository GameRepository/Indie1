using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IFinalSkill : SkillComponent
{
    public enum SkillType
    {
        None
    }
    public SkillType type;
    public string skillDescription;
    public PlayerController player;
    public String skill_name;
    public Sprite icon;
    
    /*
     * Will be called EveryFrame if skill is Active
     */
    public abstract void DoSkillMechanics();
    public abstract void Unlock();

    protected IFinalSkill(SkillType type, PlayerController player, string skillDes)
    {
        this.type = type;
        this.player = player;
        this.skillDescription = skillDes;

    }

    protected void Awake()
    {
        this.onSkillUnlocked += Unlock;
    }
    protected void Update()
    {
        if (!isActive)
            return;
        DoSkillMechanics();
    }

}
