using UnityEngine;
using TMPro;

public class UI_ItemBtn : UI_Button
{
    [SerializeField] private GameObject equipLabel;
    public int index;
    public ItemSO target;

    public override void Start()
    {
        base.Start();
        
    }
    public override void OnUI()
    {
        if(target == null)
        {
            target = GameManager.Instance.player.GetComponent<Inventory>().list[index];
        }
        
        base.OnUI();
        equipLabel.SetActive(target.isEquip);

    }
    public override void ButtonEvent()
    {

        _manager.ItemEquip.index = index;
        _manager.OpenUI(_manager.ItemEquip);

    }
}
