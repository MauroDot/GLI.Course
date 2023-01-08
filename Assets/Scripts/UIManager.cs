using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //private variable to declare teh instance of this class. -- has to be static
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("UI Manager");
                go.AddComponent<UIManager>();
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void UPdateScore(int score)
    {
        Debug.Log("Score: " + score);
        Debug.Log("Notifying the game manager");
        GameManager.Instance.DisplayName();
    }
}
