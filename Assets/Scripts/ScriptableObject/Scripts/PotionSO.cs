using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PotionItemData", menuName = "SO/Item/Potion", order = 3)]

public class PotionSO : ItemSO
{
    [Header("Potion Info")]
    public int health;
}
