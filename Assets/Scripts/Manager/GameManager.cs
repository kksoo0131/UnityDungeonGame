using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerData playerData;

    private void Awake()
    {
        Instance = this;

        playerData = new PlayerData();
    }

    private void Start()
    {
        
    }

}