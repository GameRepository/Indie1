using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    protected Animator animator;
    public PlayerModel playerModel;
    public SkillSystem skill_system;
    public bool IsGround;
    protected float iframe_Timer;
    public bool isAttacking;

    void Awake()
    {
        playerModel = gameObject.GetComponent<PlayerModel>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InputHandler()
    {

    }
    public void Walk()
    {

    }

    public void Jump()
    {

    }
    public void Attack(String command)
    {

    }

    public void Die()
    {

    }
}
