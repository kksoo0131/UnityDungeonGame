using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemSO> GetItemSO { get; private set; }

    private void Awake()
    {
        GetItemSO = new List<ItemSO>();
    }
}
