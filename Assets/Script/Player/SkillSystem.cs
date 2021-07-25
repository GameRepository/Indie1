using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSystem : MonoBehaviour
{
    // Start is called before the first frame update
    SkillComponent branch1;
    SkillComponent branch2;
    SkillComponent branch3;
    public int available_skillponints;

   
    void Start()
    {
        available_skillponints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   



    public bool TryUnlockSkill( SkillComponent skillToUnlock)
    {
        if ((skillToUnlock.parents == null || skillToUnlock.parents.isActive == true) && skillToUnlock.isActive == false)
        {
            if (available_skillponints > 0)
            {
                skillToUnlock.UnlockThisSKill();
                available_skillponints--;
                return true;
            }
            return false;
        }
           
        return false;
    }



}
