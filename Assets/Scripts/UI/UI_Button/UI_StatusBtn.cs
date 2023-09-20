public class UI_StatusBtn : UI_Button
{
    public override void ButtonEvent()
    {
        _manager.OpenUI(_manager.status);
    }
}
