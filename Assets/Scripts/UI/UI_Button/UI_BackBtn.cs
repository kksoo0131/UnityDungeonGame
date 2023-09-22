public class UI_BackBtn : UI_Button
{
    public override void ButtonEvent()
    {
        UIManager.Instance.CloseUI();
    }
    
}
