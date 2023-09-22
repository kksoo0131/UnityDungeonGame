using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatData", menuName = "SO/Stats/Stats", order = 0)]
public class StatsSO : ScriptableObject
{
    [Header("Stats Info")]

    public string characterType;
    public string characterName;
    public string characterInfo;
    public int level;
    public int exp;
    public int maxExp;

    public int attack;
    public int defense;
    public int health;
    public int critical;
}
