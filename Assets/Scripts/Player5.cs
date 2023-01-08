using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player5 : MonoSingleton<Player5>
{
    public string name;

    public override void Init()
    {
        base.Init();
        Debug.Log("Player Initialized!");
        LevelManager.Instance.LoadLevel();
    }
}
