using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficulty : MonoBehaviour
{
    public enum Difficulty
    {
        Easy, //0
        Normal, //1
        Hard, //2
        Expert //3
    }

    //public LevelSelector currentLevel;

    /*public void Start()
    {
        if(currentLevel == LevelSelector.Easy)
        {
            
        }
    }*/

    public Difficulty selectedDifficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)selectedDifficulty);
    }
}
