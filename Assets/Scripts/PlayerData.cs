using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public PlayerData()
    {
        CharacterType = "코딩노예가 되고싶다.";
        CharacterInfo = "코딩 노예가 되고 싶습니다. 누가 데려가주세요..";
        CharacterName = "Chad";
        Level = 1;
        Exp = 3;
        MaxExp = 10;
        MyInventory = new Inventory();

    }
    public string CharacterType { get; private set; }
    public string CharacterInfo { get; private set; }
    public string CharacterName { get; private set; }
    public int Level { get; private set; }
    public int Exp { get; private set; }
    public int MaxExp { get; private set; }
    
    public Inventory MyInventory { get; private set; }
}
