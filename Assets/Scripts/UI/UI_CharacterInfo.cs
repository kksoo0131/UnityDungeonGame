using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_CharacterInfo : UI
{
    private PlayerData data;
    [SerializeField] private TextMeshProUGUI characterTypeTxt;
    [SerializeField] private TextMeshProUGUI characterNameTxt;
    [SerializeField] private TextMeshProUGUI characterLevelTxt;
    [SerializeField] private TextMeshProUGUI expTxt;
    [SerializeField] private TextMeshProUGUI characterInfoTxt;

    [SerializeField] private Slider expSlider;
    private void Start()
    {
        data = GameManager.Instance.playerData;
    }
    public override void OnUI()
    {
        base.OnUI();
        UIUpdate();
    }

    public void UIUpdate()
    {
        characterTypeTxt.text = data.CharacterType;
        characterNameTxt.text = data.CharacterName;
        characterLevelTxt.text = data.Level.ToString();
        expTxt.text = data.Exp.ToString() + " / " + data.MaxExp.ToString();
        characterInfoTxt.text = data.CharacterInfo;
        expSlider.value = ((float)data.Exp) / data.MaxExp;
    }
}
