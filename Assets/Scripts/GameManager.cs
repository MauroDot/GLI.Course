using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
                Debug.LogError("The GameManager is NULL. ");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void DisplayName()
    {
        Debug.Log("My name is Mud and I come from the water");
    }
}
