using UnityEngine;

public class UI_Main : UI
{
    [SerializeField] UI_StatusBtn statusBtn;
    [SerializeField] UI_InventoryBtn inventoryBtn;
    [SerializeField] UI_CharacterInfo characterInfo;
    public override void OnUI()
    {
        base.OnUI();
        characterInfo.OnUI();
        OnButton();
    }

    public override void OffUI()
    {
        base.OffUI();
    }

    public void OnStatusBtn()
    {
        OffButton();
        statusBtn.ButtonEvent();
    }

    public void OnInventoryBtn()
    {
        OffButton();
        inventoryBtn.ButtonEvent();
    }

    public void OnButton()
    {
        statusBtn.OnUI();
        inventoryBtn.OnUI();
    }

    public void OffButton()
    {
        statusBtn.OffUI();
        inventoryBtn.OffUI();
    }


    // ���� UI_Main�� �ִ� Btn�� Ŭ����ٸ�
    // UI_Main�� �ִ� Btn���� ��� OFF�ǰ�
    // OnUI�ɶ� Btn���� �����ȴ�.
}
