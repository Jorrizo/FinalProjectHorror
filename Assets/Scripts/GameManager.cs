using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public static int objectivesDone;

    public static int objectivesBeforeDeath;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        objectivesBeforeDeath = PlayerPrefs.GetInt("Objectif", 0);
        objectivesDone = objectivesBeforeDeath;
        Debug.Log(objectivesBeforeDeath);      
             
    }

}
