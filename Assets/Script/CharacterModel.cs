using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterModel: MonoBehaviour
{
    [Header("Basic Character's Stat")]
    [Range(0f, 100f)]
    public float max_health;
    public float current_health;
    public bool isInIframe;
    [Range(0f, 0.5f)]
    public float iframeTimer;
    public float baseDamage;
    [Range(0f,10f)]
    public float movement_speed;
    [Range(0f, 10f)]
    public float jumping_force;

}
