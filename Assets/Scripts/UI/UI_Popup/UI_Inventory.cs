using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class UI_Inventory : UI
{
    public Inventory inventory;
    [SerializeField] private Transform uiLayout;

    // �κ��丮 ��ü�� �޾Ƽ�
    // ����Ʈ�� ���� �����۵��� ui Layout�� �߰��Ѵ�.

    // ��ư�� ������ �ش� �������� ����â�� ����.

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
