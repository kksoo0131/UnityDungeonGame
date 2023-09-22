using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    // baseStats == 원본 스탯
    // CurrentStats == 현재 스탯
    // statsModifiers 적용된 스탯 수정 사항
    [SerializeField] private CharacterStats baseStats;
    public CharacterStats CurrentStats { get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    public void AddStatModifier(CharacterStats statModifier)
    {
        statsModifiers.Add(statModifier);
        UpdateCharacterStats();
    }

    public void RemoveStatModifier(CharacterStats statModifier)
    {
        statsModifiers.Remove(statModifier);
        UpdateCharacterStats();
    }

    private void UpdateStatsSO(Func<int, int, int> operation, StatsSO currentStat, StatsSO newStat)
    {

        if (currentStat == null || newStat == null || currentStat.GetType() != newStat.GetType()) return;

        currentStat.level = operation(currentStat.level, newStat.level);
        currentStat.exp = operation(currentStat.exp, newStat.exp);
        currentStat.maxExp = operation(currentStat.maxExp, newStat.maxExp);

    }
    private void UpdateCharacterStats()
    {
        StatsSO statsSO = null;
        if (baseStats.statsSO != null)
        {
            statsSO = baseStats.statsSO;
        }

        CurrentStats = new CharacterStats { statsSO = statsSO };
        CurrentStats.statsChangeType = baseStats.statsChangeType;
        CurrentStats.maxHealth = baseStats.maxHealth;
    }
}
