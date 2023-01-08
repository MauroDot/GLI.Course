using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private UIManager _ui;
    void Start()
    {
        GameManager.Instance.DisplayName();
        SpawnManager.Instance.StartSpawning();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UIManager.Instance.UPdateScore(40);
        }
    }
}
