using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public static int objectivesDone;

    public Transform SP1;
    public Transform SP2;

    public static Transform Spawnpoint1;
    public static Transform Spawnpoint2;
    
    public static int objectivesBeforeDeath;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        objectivesBeforeDeath = PlayerPrefs.GetInt("Objectif", 0);
        objectivesDone = objectivesBeforeDeath;
        Debug.Log(objectivesBeforeDeath);

        Spawnpoint1 = SP1;
        Spawnpoint2 = SP2;
             
    }

}
