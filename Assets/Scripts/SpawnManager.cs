using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //create the instance (private)
    //check if th einstance is null
    //error handle

    //UnassignedReferenceException the instance (void awake)

    private static SpawnManager _instance;

    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The SpawnManager is NULL. ");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void StartSpawning()
    {
        Debug.Log("Spawn Started");
    }

    private void Start()
    {
        Debug.Log(Player5.Instance.name);
    }
}
