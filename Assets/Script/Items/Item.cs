using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject
{
    // Start is called before the first frame update
    public string itemName;
    public Sprite icon;
    public string ItemDescription;
    public float dmgBonus;
    public float hpBonus;
    public float iframeTimeBonus;

    public void Equip(PlayerModel player)
    {
        player.max_health += hpBonus;
        player.baseDamage += dmgBonus;
        player.iframeTimer += iframeTimeBonus;
    }
    public void UnEquip(PlayerModel player)
    {
        player.max_health -= hpBonus;
        player.baseDamage -= dmgBonus;
        player.iframeTimer -= iframeTimeBonus;
    }
}
