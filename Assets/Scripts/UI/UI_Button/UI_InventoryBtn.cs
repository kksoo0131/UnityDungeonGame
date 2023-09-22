public class UI_InventoryBtn : UI_Button
{
    public override void ButtonEvent()
    {
        _manager.OpenUI(_manager.inventory);
    }
}
