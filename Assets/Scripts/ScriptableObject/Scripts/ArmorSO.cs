using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ArmorItemData", menuName = "SO/Item/Armor", order = 2)]

public class ArmorSO : ItemSO
{
    [Header("Armor Info")]
    public int defense;
}
