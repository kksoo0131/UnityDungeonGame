using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class UI_Inventory : UI
{
    public Inventory inventory;
    [SerializeField] private Transform uiLayout;

    // 인벤토리 객체를 받아서
    // 리스트에 속한 아이템들을 ui Layout에 추가한다.

    // 버튼을 누르면 해당 아이템의 정보창을 띄운다.

    public override void Start()
    {
        base.Start();
        inventory = GameManager.Instance.player.GetComponent<Inventory>();
    }
    public override void OffUI()
    {
        base.OffUI();
    }

    public override void OnUI()
    {
        base.OnUI();
        for ( int i =0; i< inventory.list.Count; i++)
        {
            Transform itembtn = uiLayout.GetChild(i);
            itembtn.GetComponent<Image>().sprite = inventory.list[i].image;
            itembtn.GetComponent<UI_ItemBtn>().OnUI();
        }
        
    }
}
