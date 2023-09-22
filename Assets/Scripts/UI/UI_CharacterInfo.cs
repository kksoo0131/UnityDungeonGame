using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_CharacterInfo : UI
{
    public StatsSO StatsSO { get; private set; }
    [SerializeField] private TextMeshProUGUI characterTypeTxt;
    [SerializeField] private TextMeshProUGUI characterNameTxt;
    [SerializeField] private TextMeshProUGUI characterLevelTxt;
    [SerializeField] private TextMeshProUGUI expTxt;
    [SerializeField] private TextMeshProUGUI characterInfoTxt;

    [SerializeField] private Slider expSlider;
    public override void Start()
    {
        base.Start();
        StatsSO = GameManager.Instance.player.GetComponent<CharacterStatsHandler>().CurrentStats.statsSO;
    }
    public override void OnUI()
    {
        base.OnUI();
        UIUpdate();
    }

    public void UIUpdate()
    {
        characterTypeTxt.text = StatsSO.characterType;
        characterNameTxt.text = StatsSO.characterName;
        characterLevelTxt.text = StatsSO.level.ToString();
        expTxt.text = StatsSO.exp.ToString() + " / " + StatsSO.maxExp.ToString();
        characterInfoTxt.text = StatsSO.characterInfo;
        expSlider.value = ((float)StatsSO.exp) / StatsSO.maxExp;
    }
}
