using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponItemData", menuName = "SO/Item/Weapon", order = 1)]
public class WeaponItemSO : ItemSO
{
    [Header("Weapon Info")]
    public int attack;
}
