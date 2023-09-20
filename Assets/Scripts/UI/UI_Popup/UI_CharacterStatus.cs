using UnityEngine;
using TMPro;

public class UI_CharacterStatus : UI
{
    [SerializeField] private TextMeshProUGUI AttackTxt;
    [SerializeField] private TextMeshProUGUI DefenseTxt;
    [SerializeField] private TextMeshProUGUI HealthTxt;
    [SerializeField] private TextMeshProUGUI CriticalTxt;

    public override void OnUI()
    {
        base.OnUI();
        // 
    }
}
