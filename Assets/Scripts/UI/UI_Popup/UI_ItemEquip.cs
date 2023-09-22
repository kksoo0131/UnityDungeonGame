using UnityEngine;
using TMPro;

public class UI_ItemEquip : UI
{
    [SerializeField] private TextMeshProUGUI EquipTxt;
    public int index;
    public Inventory inventory;
    public ItemSO target;

    public override void Start()
    {
        base.Start();
        inventory = GameManager.Instance.player.GetComponent<Inventory>();
    }
    public override void OnUI()
    {
        base.OnUI();
        EquipCheck();
    }

    public void EquipCheck()
    {
        target = inventory.list[index];

        if (target.isEquip == true)
        {
            EquipTxt.text = "장착 해제 하시겠습니까?\r\n";
        }
        else
        {
            EquipTxt.text = "장착하시겠습니까?\r\n";
        }
    }

    public void ConfirmBtn()
    {
        target.isEquip = !target.isEquip;
        _manager.CloseUI();
        
    }

    public void CancelBtn()
    {
        _manager.CloseUI();
    }
}
