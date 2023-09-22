using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultItemData", menuName = "SO/Item/Default", order = 0)]
public class ItemSO : ScriptableObject
{
    [Header("Item Info")]
    public Sprite image;
    public string itemName;
    public bool isEquip;
}
