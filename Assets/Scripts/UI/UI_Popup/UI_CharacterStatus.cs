using UnityEngine;
using TMPro;

public class UI_CharacterStatus : UI
{
    [SerializeField] private TextMeshProUGUI AttackTxt;
    [SerializeField] private TextMeshProUGUI DefenseTxt;
    [SerializeField] private TextMeshProUGUI HealthTxt;
    [SerializeField] private TextMeshProUGUI CriticalTxt;
    public StatsSO playerstat;
    public override void OnUI()
    {
        playerstat = GameManager.Instance.player.GetComponent<CharacterStatsHandler>().CurrentStats.statsSO;
        base.OnUI();

        AttackTxt.text = playerstat.attack.ToString();
        DefenseTxt.text = playerstat.defense.ToString();
        HealthTxt.text = playerstat.health.ToString();
        CriticalTxt.text = playerstat.critical.ToString();

    }
}
