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


    // 만약 UI_Main에 있는 Btn이 클릭됬다면
    // UI_Main에 있는 Btn들이 모두 OFF되고
    // OnUI될때 Btn들이 복구된다.
}
