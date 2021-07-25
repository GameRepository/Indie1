using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : SkillComponent
{
    string group_name;
    string group_description;
    

    protected List<SkillComponent> Child_Skills;
    IFinalSkill thisSkill;
    public SkillTree(IFinalSkill skill,string GroupName, string GroupDescription)
    {
        this.group_name = GroupName;
        this.group_description = GroupDescription;
        Child_Skills = new List<SkillComponent>();
        this.thisSkill = skill;
    }
    public void add(SkillComponent news_skillComponent)
    {
        Child_Skills.Add(news_skillComponent);
        news_skillComponent.parents = this;
    }
    public void remove(SkillComponent news_skillComponent)
    {
        Child_Skills.Remove(news_skillComponent);
        news_skillComponent.parents = null;
    }
    public string GetName()
    {
        return group_name;
    }
    public string GetDescription()
    {
        return group_description;
    }
    protected void Awake()
    {
        this.onSkillUnlocked += UnlockBranch;
    }
    protected void UnlockBranch()
    {
        this.isActive = true;
        this.thisSkill.Unlock() ;
    }
}
